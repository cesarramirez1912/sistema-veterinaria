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
    public partial class FormMedicamento : Form
    {
        private MedicamentoServico medicamentoServico = new MedicamentoServico();
        bool editar = false;
        string id = null;

        public FormMedicamento()
        {
            InitializeComponent();
        }

        public FormMedicamento(Medicamento medicamentoEdit)
        {
            InitializeComponent();
            editar = true;
            txtDescricao.Text = medicamentoEdit.Descricao;
            txtPreco.Text = medicamentoEdit.ValorUnitario.ToString();
            this.id = medicamentoEdit.MedicamentoId.ToString();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                medicamentoServico.EditarMedicamento(new Medicamento()
                {
                    MedicamentoId = Convert.ToInt64(id),
                    Descricao = txtDescricao.Text,
                    ValorUnitario = Convert.ToDouble(txtPreco.Text),

                });
                txtPreco.Clear();
                txtDescricao.Clear();
            }
            if (editar == false)
            {

                medicamentoServico.GravarMedicamento(new Medicamento()
                {
                    Descricao = txtDescricao.Text,
                    ValorUnitario = Convert.ToDouble(txtPreco.Text),

                });

                txtPreco.Clear();
                txtDescricao.Clear();

            }
        }
    }
}
