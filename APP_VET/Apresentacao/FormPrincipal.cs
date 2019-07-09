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
    public partial class FormPrincipal : Form
    {
       
        

        public FormPrincipal(string user)
        {
            InitializeComponent();
            SidePanel.Top = btnCliente.Top;
            SidePanel.Height = btnCliente.Height;
            clienteControle1.BringToFront();
            label2.Text = user;
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height= btnCliente.Height;
            SidePanel.Top = btnCliente.Top;
           clienteControle1.BringToFront();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAnimal.Height;
            SidePanel.Top = btnAnimal.Top;
           animal_Controle1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnConsulta.Height;
            SidePanel.Top = btnConsulta.Top;
            consulta_Controle1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnVeterinario.Height;
            SidePanel.Top = btnVeterinario.Top;
            veterinario_Controle1.BringToFront();
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMedicamentos.Height;
            SidePanel.Top = btnMedicamentos.Top;
            medicamento_Controle1.BringToFront();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
