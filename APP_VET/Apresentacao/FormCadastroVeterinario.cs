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
    public partial class FormCadastroVeterinario : Form
    {
        Veterinario veterinario = new Veterinario();
        VeterinarioServico veterinarioServico = new VeterinarioServico();
        bool Editar = false;


        public FormCadastroVeterinario()
        {
            InitializeComponent();
        }

        public FormCadastroVeterinario(Veterinario veterinarioEdit)
        {
            InitializeComponent();
            this.veterinario = veterinarioEdit;
            txtNome.Text = veterinario.Nome;
            txtTelefone.Text = veterinario.Telefone.ToString();
            txtCidade.Text = veterinario.Cidade;
            txtCpf.Text = veterinario.Cpf.ToString();
            txtEndereco.Text = veterinario.Endereco;
            txtSalario.Text = veterinario.Salario.ToString();
            Editar = true;
            btnSalvar.Text = "Modificar";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Editar)
            {
                veterinarioServico.EditarVeterinario(new Veterinario{
                    VeterinarioId = veterinario.VeterinarioId,
                    Nome = txtNome.Text,
                    Telefone = txtTelefone.Text,
                    Cidade = txtCidade.Text,
                    Cpf = txtCpf.Text,
                    Endereco = txtEndereco.Text,
                    Salario = (float) Convert.ToDouble(txtSalario.Text),
                });
                txtNome.Clear();
                txtTelefone.Clear();
                txtCidade.Clear();
                txtCpf.Clear();
                txtEndereco.Clear();
                txtSalario.Clear();
            }
            if (Editar==false)
            {
                veterinarioServico.GravarVeterinario(new Veterinario
                {
                    Nome = txtNome.Text,
                    Telefone =txtTelefone.Text,
                    Cidade = txtCidade.Text,
                    Cpf = txtCpf.Text,
                    Endereco = txtEndereco.Text,
                    Salario = (float)Convert.ToDouble(txtSalario.Text),
                });
                txtNome.Clear();
                txtTelefone.Clear();
                txtCidade.Clear();
                txtCpf.Clear();
                txtEndereco.Clear();
                txtSalario.Clear();
            }
        }
    }
}
