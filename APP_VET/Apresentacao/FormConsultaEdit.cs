using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servico;
using Modelo;

namespace Apresentacao
{
    public partial class FormConsultaEdit : Form
    {
        float somaTotal = 0;
        private MedicamentoServico servicoMedicamento = new MedicamentoServico();
        private MedicamentoConsultaServico medicamentoConsultaServico = new MedicamentoConsultaServico();
        private Consulta consultaEdit = new Consulta();
        private ConsultaServico consultaServico = new ConsultaServico();
        private Consulta consultaArmazenada = new Consulta();
        string id = null;
        List<string> statusConsulta = new List<string>(new string[] { "Marcado", "Cancelado", "Atendido" });
        List<string> statusPagamento = new List<string>(new string[] { "Pago", "Nao Pago" });

        public FormConsultaEdit(Consulta consulta)
        {

            this.consultaEdit = consulta;
            InitializeComponent();
            RefreshDataGridView();
            comboBoxStatus.DataSource = statusConsulta;
            comboBoxPagamento.DataSource = statusPagamento;
            dateTimeConsulta.MinDate = consultaEdit.DataConsulta;
            txtIdVeterinario.Text = consultaEdit.VeterinarioId.ToString();
            txtIdClienteConsulta.Text = consultaEdit.ClienteId.ToString();
            txtIdAnimal.Text = consultaEdit.AnimalId.ToString();
            txtValorTotal.Text = consultaEdit.ValorTotalConsulta.ToString();
            txtObservacao.Text = consultaEdit.Observacao.ToString();
            id = consultaEdit.ConsultaId.ToString();
            txtValorTotal.Enabled = false;
            txtIdVeterinario.Enabled = false;
            txtIdAnimal.Enabled = false;
            txtIdClienteConsulta.Enabled = false;
            txtObservacao.Enabled = false;
            int index = statusPagamento.IndexOf(consultaEdit.EstatusPagamento);
            int index2 = statusConsulta.IndexOf(consultaEdit.EstatusConsulta);
            comboBoxPagamento.SelectedIndex = index;
            comboBoxStatus.SelectedIndex = index2;
            RefreshDataGridCarrinho();
            txtValorTotal.Text = (somaTotal+consultaEdit.ValorTotalConsulta).ToString();
            this.somaTotal = (somaTotal + (float)Convert.ToDouble(txtValorTotal.Text));
        }

        private void RefreshDataGridView()
        {
            dgvMedicamentos.DataSource = servicoMedicamento.TodosOsMedicamentos();
 
        }

        private void RefreshDataGridCarrinho()
        {
            dgvCarrinho.DataSource = medicamentoConsultaServico.TodasAsConsultasMedicamentosPorId(Convert.ToInt64(id));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            consultaServico.AtualizarPrecoConsulta(new Consulta() {
                AnimalId=consultaEdit.AnimalId,
                ClienteId= consultaEdit.ClienteId,
                ConsultaId= consultaEdit.ConsultaId,
                DataConsulta= Convert.ToDateTime(dateTimeConsulta.Text),
                EstatusConsulta = comboBoxStatus.SelectedValue.ToString(),
                Observacao= consultaEdit.Observacao,
                EstatusPagamento = comboBoxPagamento.SelectedValue.ToString(),
                ValorTotalConsulta= consultaEdit.ValorTotalConsulta,
                VeterinarioId= consultaEdit.VeterinarioId,
            });
            consultaArmazenada.AnimalId = consultaEdit.AnimalId;
            consultaArmazenada.ClienteId = consultaEdit.ClienteId;
            consultaArmazenada.ConsultaId = consultaEdit.ConsultaId;
            consultaArmazenada.DataConsulta = Convert.ToDateTime(dateTimeConsulta.Text);
            consultaArmazenada.EstatusConsulta = comboBoxStatus.SelectedValue.ToString();
            consultaArmazenada.Observacao = consultaEdit.Observacao;
            consultaArmazenada.EstatusPagamento = comboBoxPagamento.SelectedValue.ToString();
            consultaArmazenada.ValorTotalConsulta = consultaEdit.ValorTotalConsulta;
            consultaArmazenada.VeterinarioId = consultaEdit.VeterinarioId;
            MessageBox.Show("Consulta Editada!");
            btnSalvar.Enabled = false;
            comboBoxPagamento.Enabled = false;
            comboBoxStatus.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtQuantidade.Text) == 0)
                {
                    MessageBox.Show("Numero tem que ser diferente de 0");
                    throw new Exception();
                }

                medicamentoConsultaServico.GravarConsultaMedicamento(new ConsultaMedicamento()
                {
                    ConsultaId = Convert.ToInt64(id),
                    MedicamentoId = Convert.ToInt64(dgvMedicamentos.CurrentRow.Cells["MedicamentoId"].Value.ToString()),
                    Quantidade = Convert.ToInt32(txtQuantidade.Text),
                    ValorUnitario = (float)Convert.ToDouble(dgvMedicamentos.CurrentRow.Cells["ValorUnitario"].Value.ToString()),
                });
                float qntdXvalor = (float)Convert.ToDouble(dgvMedicamentos.CurrentRow.Cells["ValorUnitario"].Value.ToString()) * Convert.ToUInt32(txtQuantidade.Text);
                somaTotal = somaTotal + qntdXvalor;
                txtValorTotal.Text = somaTotal.ToString();

                consultaServico.AtualizarPrecoConsulta(new Consulta()
                {
                    AnimalId = consultaEdit.AnimalId,
                    ClienteId = consultaEdit.ClienteId,
                    ConsultaId = consultaEdit.ConsultaId,
                    DataConsulta = Convert.ToDateTime(dateTimeConsulta.Text),
                    EstatusConsulta = comboBoxStatus.SelectedValue.ToString(),
                    Observacao = consultaEdit.Observacao,
                    EstatusPagamento = comboBoxPagamento.SelectedValue.ToString(),
                    ValorTotalConsulta = Convert.ToDouble(txtValorTotal.Text),
                    VeterinarioId = consultaEdit.VeterinarioId,
                });
                RefreshDataGridCarrinho();
            }
            catch (Exception exp)
            {
                if (string.IsNullOrEmpty(txtQuantidade.Text))
                {
                    MessageBox.Show("Preencha a propiedade de quantidade");
                }
            }
        }

        private void bntExcluirCarrinho_Click(object sender, EventArgs e)
        {

            try
            {
                medicamentoConsultaServico.ExcluirConsultaMedicamento(Convert.ToInt64(dgvCarrinho.CurrentRow.Cells["ConsultaMedicamentoId"].Value.ToString()));
                String.Format("{0:0.00}", dgvMedicamentos.CurrentRow.Cells["ValorUnitario"].Value.ToString());
                float testeste = (Convert.ToInt32(dgvCarrinho.CurrentRow.Cells["Quantidade"].Value.ToString()) * (float)Convert.ToDouble(dgvCarrinho.CurrentRow.Cells["ValorUnitario"].Value.ToString()));

                somaTotal = somaTotal - (Convert.ToInt32(dgvCarrinho.CurrentRow.Cells["Quantidade"].Value.ToString()) * (float)Convert.ToDouble(dgvCarrinho.CurrentRow.Cells["ValorUnitario"].Value.ToString()));
                txtValorTotal.Text = String.Format("{0:0.00}", somaTotal);
                RefreshDataGridCarrinho();
                consultaServico.AtualizarPrecoConsulta(new Consulta()
                {
                    AnimalId = consultaEdit.AnimalId,
                    ClienteId = consultaEdit.ClienteId,
                    ConsultaId = consultaEdit.ConsultaId,
                    DataConsulta = Convert.ToDateTime(dateTimeConsulta.Text),
                    EstatusConsulta = comboBoxStatus.SelectedValue.ToString(),
                    Observacao = consultaEdit.Observacao,
                    EstatusPagamento = comboBoxPagamento.SelectedValue.ToString(),
                    ValorTotalConsulta = Convert.ToDouble(txtValorTotal.Text),
                    VeterinarioId = consultaEdit.VeterinarioId,
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
