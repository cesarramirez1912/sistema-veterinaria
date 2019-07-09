using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class ConsultaServico
    {
        private ConsultaDAL consultaDal = new ConsultaDAL();

        public IList<Consulta> TodasAsConsultas()
        {
            return consultaDal.TodasAsConsultas();
        }


        public IList<Consulta> FiltrarPorIdConsulta(string id)
        {
            return consultaDal.FiltrarPorIdConsulta(id);
        }

        public IList<Consulta> FiltrarPorData(string data)
        {
            return consultaDal.FiltrarPorData(data);
        }

        public void AtualizarPrecoConsulta(Consulta consulta)
        {
            { 
            consultaDal.AtualizarPrecoConsulta(consulta);
            }
        }

        public long GravarConsulta(Consulta consulta)
        {
           return consultaDal.GravarConsulta(consulta);
        }

        public void EditarConsulta(Consulta consulta)
        {
            consultaDal.EditarConsulta(consulta);
        }
    }
}
