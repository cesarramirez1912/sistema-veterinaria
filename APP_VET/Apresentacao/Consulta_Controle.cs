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
    public partial class Consulta_Controle : UserControl
    {
        ConsultaServico consultaServico = new ConsultaServico();
        
 
        public Consulta_Controle()
        {
            InitializeComponent();
            DataGridViewRefresh();
        }

        private void DataGridViewRefresh()
        {
            dgvConsultas.DataSource = consultaServico.TodasAsConsultas();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRefresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormConsultaEdit formConsultaEdit = new FormConsultaEdit(new Consulta() {
                ConsultaId = Convert.ToInt64(dgvConsultas.CurrentRow.Cells["ConsultaId"].Value.ToString()),
                AnimalId = Convert.ToInt32(dgvConsultas.CurrentRow.Cells["AnimalId"].Value.ToString()),
                ClienteId= Convert.ToInt64(dgvConsultas.CurrentRow.Cells["ClienteId"].Value.ToString()),
                DataConsulta = Convert.ToDateTime(dgvConsultas.CurrentRow.Cells["DataConsulta"].Value.ToString()),
                EstatusConsulta = dgvConsultas.CurrentRow.Cells["EstatusConsulta"].Value.ToString(),
                EstatusPagamento= dgvConsultas.CurrentRow.Cells["EstatusPagamento"].Value.ToString(),
                Observacao= dgvConsultas.CurrentRow.Cells["Observacao"].Value.ToString(),
                VeterinarioId= Convert.ToInt64(dgvConsultas.CurrentRow.Cells["VeterinarioId"].Value.ToString()),
                ValorTotalConsulta= Convert.ToDouble(dgvConsultas.CurrentRow.Cells["ValorTotalConsulta"].Value.ToString()),
            });
            formConsultaEdit.Show();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
            string data = dataFiltroConsulta.Text;
            dataFiltroConsulta.Value.Year.ToString();
            dgvConsultas.DataSource = consultaServico.FiltrarPorData(data);
        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            dgvConsultas.DataSource = consultaServico.FiltrarPorIdConsulta(id);
        }
    }
}
