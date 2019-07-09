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
    public partial class Medicamento_Controle : UserControl
    {
        bool editar = false;
        private MedicamentoServico medicamentoServico = new MedicamentoServico();

        public Medicamento_Controle()
        {
            InitializeComponent();
            DataGridViewRefresh();
        }

        private void DataGridViewRefresh()
        {
            dgvMedicamentos.DataSource = medicamentoServico.TodosOsMedicamentos();
        }

        private void btnNovoMedicamento_Click(object sender, EventArgs e)
        {
            FormMedicamento formMedicamento = new FormMedicamento();
            formMedicamento.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRefresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormMedicamento formMedicamento = new FormMedicamento(
                new Modelo.Medicamento()
                {
                    MedicamentoId = Convert.ToInt64(dgvMedicamentos.CurrentRow.Cells["MedicamentoId"].Value.ToString()),
                    Descricao = dgvMedicamentos.CurrentRow.Cells["Descricao"].Value.ToString(),
                    ValorUnitario = Convert.ToDouble(dgvMedicamentos.CurrentRow.Cells["ValorUnitario"].Value.ToString()),
                }
                );
            formMedicamento.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            medicamentoServico.ExcluirMedicamento(Convert.ToInt32(dgvMedicamentos.CurrentRow.Cells["MedicamentoId"].Value.ToString()));
            DataGridViewRefresh();
        }
    }
}
