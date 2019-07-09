using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Apresentacao
{
    public partial class FormLogin : Form
    {
        Thread telaTh;
        private string txtUsuario = null;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.txtUsuario = txtUserName.Text;
            this.Close();
            telaTh = new Thread(novaTela);
            telaTh.SetApartmentState(ApartmentState.STA);
            telaTh.Start();
        }

        private void novaTela()
        {
            Application.Run(new FormPrincipal(txtUsuario));
        }
    }
}
