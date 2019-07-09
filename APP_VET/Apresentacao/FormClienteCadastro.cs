 using Modelo;
using Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FormClienteCadastro : Form
    {
        private ClienteServico clienteServico = new ClienteServico();
        private AnimalServico animalServico = new AnimalServico();
        private bool Editar = false;
        Cliente cliente = new Cliente();

        public FormClienteCadastro(Cliente clienteEdit)
        {
            InitializeComponent();
            this.cliente = clienteEdit;
            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone.ToString();
            txtCidade.Text = cliente.Cidade;
            txtCpf.Text = cliente.Cpf.ToString();
            txtEndereco.Text = cliente.Endereco;
            txtEspecie.Enabled = false;
            txtIdade.Enabled = false;
            txtNomeAnimal.Enabled = false;
            txtPelagem.Enabled = false;
            Editar = true;
            btnSalvar.Text = "Modificar";
        }


        public FormClienteCadastro()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Editar)
            {
                clienteServico.EditarCliente(
                            new Modelo.Cliente()
                            { 
                                ClienteId = cliente.ClienteId,
                                Nome = txtNome.Text,
                                Telefone = txtTelefone.Text,
                                Endereco = txtEndereco.Text,
                                Cidade = txtCidade.Text,
                                Cpf = txtCpf.Text,
                            });
                this.Close();
            }
            if (Editar == false)
            {
                long novoIdCliente = clienteServico.GravarCliente(
                            new Modelo.Cliente()
                            {
                                Nome = txtNome.Text,
                                Telefone = txtTelefone.Text,
                                Endereco = txtEndereco.Text,
                                Cidade = txtCidade.Text,
                                Cpf = txtCpf.Text,
                            });

                animalServico.GravarAnimal(new Modelo.Animal()
                {
                    ClienteId = novoIdCliente,
                    Nome = txtNomeAnimal.Text,
                    Especie = txtEspecie.Text,
                    Idade = Convert.ToInt32(txtIdade.Text),
                    Pelagem = txtPelagem.Text,

                });
                txtNome.Clear();
                txtTelefone.Clear();
                txtEndereco.Clear();
                txtCidade.Clear();
                txtCpf.Clear();
                txtNomeAnimal.Clear();
                txtEspecie.Clear();
                txtIdade.Clear();
                txtPelagem.Clear();
            }
        }


    }
}