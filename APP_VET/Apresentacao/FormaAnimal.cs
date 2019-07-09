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

namespace Apresentacao
{
    public partial class FormaAnimal : Form
    {
        private AnimalServico animalServico = new AnimalServico();
        private bool Editar = false;
        public string Id = null;

        public FormaAnimal(string id)
        {
            InitializeComponent();
            txtIDCliente.Text = id;
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            dgvCdAnimal.DataSource = animalServico.ObterPorId(Convert.ToInt32(txtIDCliente.Text));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                animalServico.GravarAnimal(new Modelo.Animal()
                {
                    ClienteId = Convert.ToInt64(txtIDCliente.Text),
                    Nome = txtNomeAnimal.Text,
                    Especie = txtEspecie.Text,
                    Idade = Convert.ToInt32(txtIdade.Text),
                    Pelagem = txtPelagem.Text,
                });
                txtEspecie.Clear();
                txtNomeAnimal.Clear();
                txtIdade.Clear();
                txtPelagem.Clear();
                RefreshDataGridView();
               
            }
            if (Editar)
            {
               
                animalServico.EditarAnimal(new Modelo.Animal()
                {
                    ClienteId = Convert.ToInt64(txtIDCliente.Text),
                    AnimalId = Convert.ToInt64(Id),
                    Nome = txtNomeAnimal.Text,
                    Idade = Convert.ToInt32(txtIdade.Text),
                    Pelagem = txtPelagem.Text,
                    Especie = txtEspecie.Text,
                });
                txtEspecie.Clear();
                txtNomeAnimal.Clear();
                txtIdade.Clear();
                txtPelagem.Clear();
                RefreshDataGridView();
                Editar = false;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string idAnimal = dgvCdAnimal.CurrentRow.Cells["AnimalId"].Value.ToString();
            animalServico.ExcluirAnimal(idAnimal);
            RefreshDataGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
                Id = dgvCdAnimal.CurrentRow.Cells["AnimalId"].Value.ToString();
                txtIDCliente.Text = dgvCdAnimal.CurrentRow.Cells["ClienteId"].Value.ToString();
                txtNomeAnimal.Text = dgvCdAnimal.CurrentRow.Cells["Nome"].Value.ToString();
                txtEspecie.Text = dgvCdAnimal.CurrentRow.Cells["Especie"].Value.ToString();
                txtIdade.Text = dgvCdAnimal.CurrentRow.Cells["Idade"].Value.ToString();
                txtPelagem.Text = dgvCdAnimal.CurrentRow.Cells["Pelagem"].Value.ToString();
            Editar = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

 

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvCdAnimal.DataSource = animalServico.ObterPorId(Convert.ToInt32(txtIDCliente.Text));
        }
    }
}
