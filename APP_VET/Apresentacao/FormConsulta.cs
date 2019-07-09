using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Servico;

namespace Apresentacao
{
    public partial class FormConsulta : Form
    {
        private MedicamentoServico servicoMedicamento = new MedicamentoServico();
        private MedicamentoConsultaServico medicamentoConsultaServico = new MedicamentoConsultaServico();
        private Cliente clienteConsulta = new Cliente();
        private Consulta consultaEdit = new Consulta();
        private AnimalServico animalServico = new AnimalServico();
        private ClienteServico clienteServico = new ClienteServico();
        private VeterinarioServico veterinarioServico = new VeterinarioServico();
        private ConsultaServico consultaServico = new ConsultaServico();
        private Consulta consultaArmazenada = new Consulta();
        private long idConsulta;
        float valorTotal = 0;
        List<string> statusString = new List<string>(new string[] { "Marcado", "Cancelado", "Atendido" });
        List<string> statusPagamento = new List<string>(new string[] { "Pago", "Nao Pago"});


        public FormConsulta(Cliente cliente)
        {
            this.clienteConsulta = cliente;
            InitializeComponent();
            refreshGrid();
            refreshGridCarrinho();
            refreshGridMedicamentos();
            txtIdClienteConsulta.Text = clienteConsulta.ClienteId.ToString();
            txtNomeClienteConsulta.Text = clienteConsulta.Nome;
            txtNomeClienteConsulta.Enabled = false;
            txtIdClienteConsulta.Enabled = false;
            button1.Enabled = false;
            bntExcluirCarrinho.Enabled = false;
        }

        private void refreshGridMedicamentos()
        {
            dgvMedicamentos.DataSource = servicoMedicamento.TodosOsMedicamentos();
        }


        private void refreshGridCarrinho()
        {
            dgvCarrinho.DataSource = medicamentoConsultaServico.TodasAsConsultasMedicamentosPorId(Convert.ToInt64(idConsulta));
        }

        private void refreshGrid()
        {
            try
            {
                List<Animal> animais = new List<Animal>();
                comboBox2.DataSource = veterinarioServico.TodosOsVeterinarios();
                comboBox2.ValueMember = "VeterinarioId";
                comboBox2.DisplayMember = "Nome";
                comboBoxStatus.DataSource = statusString;
                comboBoxPagamento.DataSource = statusPagamento;
                animais = animalServico.ObterPorId(Convert.ToInt64(txtIdClienteConsulta.Text = clienteConsulta.ClienteId.ToString())).ToList();
                comboBox1.DataSource = animais;
                comboBox1.ValueMember = "AnimalId";
                comboBox1.DisplayMember = "Nome";
                
            }
            catch (NullReferenceException exp)
            {
                MessageBox.Show("Nao existe animal cadastrado para este usuario, cadastre-o");
            }
        }

        private void btnNovoAnimal_Click_1(object sender, EventArgs e)
        {
            FormaAnimal formAnimal = new FormaAnimal(txtIdClienteConsulta.Text = clienteConsulta.ClienteId.ToString());
            formAnimal.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.idConsulta = consultaServico.GravarConsulta(new Modelo.Consulta()
                {
                    ClienteId = Convert.ToInt64(txtIdClienteConsulta.Text),
                    AnimalId = Convert.ToInt32(comboBox1.SelectedValue.ToString()),
                    DataConsulta = Convert.ToDateTime(dateTimeConsulta.Text),
                    EstatusConsulta = comboBoxStatus.SelectedValue.ToString(),
                    VeterinarioId = Convert.ToInt64(comboBox2.SelectedValue.ToString()),
                    EstatusPagamento = comboBoxPagamento.SelectedValue.ToString(),
                    ValorTotalConsulta = valorTotal,
                    Observacao = txtObservacao.Text,
                });
                this.consultaArmazenada = new Consulta()
                {
                    ConsultaId = idConsulta,
                    ClienteId = Convert.ToInt64(txtIdClienteConsulta.Text),
                    AnimalId = Convert.ToInt32(comboBox1.SelectedValue.ToString()),
                    DataConsulta = Convert.ToDateTime(dateTimeConsulta.Text),
                    EstatusConsulta = comboBoxStatus.SelectedValue.ToString(),
                    VeterinarioId = Convert.ToInt64(comboBox2.SelectedValue.ToString()),
                    EstatusPagamento = comboBoxPagamento.SelectedValue.ToString(),
                    ValorTotalConsulta = valorTotal,
                    Observacao = txtObservacao.Text,
                };
                dateTimeConsulta.Enabled = false;
                comboBoxPagamento.Enabled = false;
                comboBoxStatus.Enabled = false;
                comboBox2.Enabled = false;
                comboBox1.Enabled = false;
                btnSalvar.Enabled = false;
                txtObservacao.Enabled = false;
                txtValorTotal.Enabled=false;
                refreshGrid();
                refreshGridCarrinho();
                refreshGridMedicamentos();
                button1.Enabled = true;
                bntExcluirCarrinho.Enabled = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                medicamentoConsultaServico.GravarConsultaMedicamento(new ConsultaMedicamento()
                {
                    ConsultaId = Convert.ToInt64(idConsulta),
                    MedicamentoId = Convert.ToInt64(dgvMedicamentos.CurrentRow.Cells["MedicamentoId"].Value.ToString()),
                    Quantidade = Convert.ToInt32(txtQuantidade.Text),
                    ValorUnitario = (float)Convert.ToDouble(dgvMedicamentos.CurrentRow.Cells["ValorUnitario"].Value.ToString()),
                });
                valorTotal = valorTotal + (Convert.ToInt32(txtQuantidade.Text) * (float)Convert.ToDouble(dgvMedicamentos.CurrentRow.Cells["ValorUnitario"].Value.ToString()));
                txtValorTotal.Text = String.Format("{0:0.00}", valorTotal);
                consultaServico.AtualizarPrecoConsulta(new Consulta()
                {
                    ConsultaId = consultaArmazenada.ConsultaId,
                    ClienteId = consultaArmazenada.ClienteId,
                    AnimalId = consultaArmazenada.AnimalId,
                    DataConsulta = consultaArmazenada.DataConsulta,
                    EstatusConsulta = consultaArmazenada.EstatusConsulta,
                    EstatusPagamento = consultaArmazenada.EstatusPagamento,
                    Observacao = consultaArmazenada.Observacao,
                    VeterinarioId = consultaArmazenada.VeterinarioId,
                    ValorTotalConsulta = Convert.ToDouble(txtValorTotal.Text),
                });
                refreshGridCarrinho();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void bntExcluirCarrinho_Click(object sender, EventArgs e)
        {
            try
            {
                medicamentoConsultaServico.ExcluirConsultaMedicamento(Convert.ToInt64(dgvCarrinho.CurrentRow.Cells["ConsultaMedicamentoId"].Value.ToString()));
                String.Format("{0:0.00}", dgvMedicamentos.CurrentRow.Cells["ValorUnitario"].Value.ToString());
                float testeste = (Convert.ToInt32(dgvCarrinho.CurrentRow.Cells["Quantidade"].Value.ToString()) * (float)Convert.ToDouble(dgvCarrinho.CurrentRow.Cells["ValorUnitario"].Value.ToString()));

                valorTotal = valorTotal - (Convert.ToInt32(dgvCarrinho.CurrentRow.Cells["Quantidade"].Value.ToString()) * (float)Convert.ToDouble(dgvCarrinho.CurrentRow.Cells["ValorUnitario"].Value.ToString()));
                txtValorTotal.Text = String.Format("{0:0.00}", valorTotal);
                refreshGridCarrinho();
                consultaServico.AtualizarPrecoConsulta(new Consulta()
                {
                    ConsultaId = consultaArmazenada.ConsultaId,
                    ClienteId = consultaArmazenada.ClienteId,
                    AnimalId = consultaArmazenada.AnimalId,
                    DataConsulta = consultaArmazenada.DataConsulta,
                    EstatusConsulta = consultaArmazenada.EstatusConsulta,
                    EstatusPagamento = consultaArmazenada.EstatusPagamento,
                    Observacao = consultaArmazenada.Observacao,
                    VeterinarioId = consultaArmazenada.VeterinarioId,
                    ValorTotalConsulta = Convert.ToDouble(txtValorTotal.Text),
                });
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
