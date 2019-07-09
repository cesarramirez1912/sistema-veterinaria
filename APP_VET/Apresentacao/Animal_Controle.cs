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
    public partial class Animal_Controle : UserControl
    {
        AnimalServico animalServico = new AnimalServico();

        public Animal_Controle()
        {
            InitializeComponent();
            DataGridViewRefresh();
        }

        private void DataGridViewRefresh()
        {
            dgvAnimal.DataSource = animalServico.TodosOsAnimais();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRefresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nomeAnimal = txtBusca.Text.ToString();
            dgvAnimal.DataSource = animalServico.FiltrarPorNomeAnimal(nomeAnimal);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            long idCliente = Convert.ToInt32(dgvAnimal.CurrentRow.Cells["ClienteId"].Value.ToString());
            FormaAnimal formaAnimal = new FormaAnimal(idCliente.ToString());
            formaAnimal.Show();
        }
    }
}
