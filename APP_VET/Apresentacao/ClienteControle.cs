using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servico;
using Modelo;

namespace Apresentacao
{
    public partial class ClienteControle : UserControl
    {
        private ClienteServico clienteServico = new ClienteServico();
        private Cliente cliente = new Cliente();
        string teste = null;

        private void RefreshDataGridView()
        {
            dgvCliente.DataSource = clienteServico.TodosOsClientes();
        }

        public ClienteControle()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void btnNovoCliente_Click_1(object sender, EventArgs e)
        {

            FormClienteCadastro formClienteCadastro = new FormClienteCadastro();
            formClienteCadastro.Show();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                cliente.ClienteId = Convert.ToInt64(dgvCliente.CurrentRow.Cells["ClienteId"].Value.ToString());
                cliente.Nome = dgvCliente.CurrentRow.Cells["Nome"].Value.ToString();
                cliente.Cidade = dgvCliente.CurrentRow.Cells["Cidade"].Value.ToString();
                cliente.Cpf = dgvCliente.CurrentRow.Cells["Cpf"].Value.ToString();
                cliente.Endereco = dgvCliente.CurrentRow.Cells["Endereco"].Value.ToString();
                cliente.Telefone = dgvCliente.CurrentRow.Cells["Telefone"].Value.ToString();
                FormClienteCadastro formClienteCadastro = new FormClienteCadastro(cliente);
                formClienteCadastro.Show();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Nao existe cliente cadastrado para poder editar");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.ClienteId = Convert.ToInt64(dgvCliente.CurrentRow.Cells["ClienteId"].Value.ToString());
                clienteServico.ExcluirCliente(cliente.ClienteId.ToString());
                RefreshDataGridView();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Nao existe cadastro para Exclusao");
            }
        }

        private void btnCadastrarAnimal_Click_1(object sender, EventArgs e)
        {
            try
            {
                cliente.ClienteId = Convert.ToInt64(dgvCliente.CurrentRow.Cells["ClienteId"].Value.ToString());
                FormaAnimal formaAnimal = new FormaAnimal(cliente.ClienteId.ToString());
                formaAnimal.Show();
            }
            catch (NullReferenceException exp)
            {
                MessageBox.Show("Nao existe cliente cadastrado para poder cadastrar um animal!");
            }
        }

        private void btnNovaConsulta_Click_1(object sender, EventArgs e)
        {
            try
            {
                cliente.ClienteId = Convert.ToInt64(dgvCliente.CurrentRow.Cells["ClienteId"].Value.ToString());
                cliente.Nome = dgvCliente.CurrentRow.Cells["Nome"].Value.ToString();
                FormConsulta formConsulta = new FormConsulta(cliente);
                formConsulta.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Nao existe cadastro para uma nova consulta!");
            }
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtBusca.Text.ToString();
            dgvCliente.DataSource = clienteServico.FiltrarPorNome(nome);
        }
    }
}
