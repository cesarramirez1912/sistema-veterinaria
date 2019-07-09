using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Servico;

namespace Apresentacao
{
    public partial class Veterinario_Controle : UserControl
    {
        private VeterinarioServico veterinarioServico = new VeterinarioServico();
        private Veterinario veterinario = new Veterinario();

        public Veterinario_Controle()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dgvVeterinario.DataSource = veterinarioServico.TodosOsVeterinarios();
        }


        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            FormCadastroVeterinario formVeterinarioCadastro = new FormCadastroVeterinario();
            formVeterinarioCadastro.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                veterinario.VeterinarioId = Convert.ToInt64(dgvVeterinario.CurrentRow.Cells["VeterinarioId"].Value.ToString());
                veterinario.Nome = dgvVeterinario.CurrentRow.Cells["Nome"].Value.ToString();
                veterinario.Cidade = dgvVeterinario.CurrentRow.Cells["Cidade"].Value.ToString();
                veterinario.Cpf = dgvVeterinario.CurrentRow.Cells["Cpf"].Value.ToString();
                veterinario.Endereco = dgvVeterinario.CurrentRow.Cells["Endereco"].Value.ToString();
                veterinario.Telefone = dgvVeterinario.CurrentRow.Cells["Telefone"].Value.ToString();
                veterinario.Salario = (float)Convert.ToDouble(dgvVeterinario.CurrentRow.Cells["Salario"].Value.ToString());
                FormCadastroVeterinario formCadastroEdit = new FormCadastroVeterinario(veterinario);
                formCadastroEdit.Show();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Nao existe veterinario cadastrado para poder editar");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                veterinario.VeterinarioId = Convert.ToInt64(dgvVeterinario.CurrentRow.Cells["VeterinarioId"].Value.ToString());
                veterinarioServico.ExcluirVeterinario(veterinario.VeterinarioId.ToString());
                RefreshDataGridView();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Nao existe veterinario para exclusao");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
