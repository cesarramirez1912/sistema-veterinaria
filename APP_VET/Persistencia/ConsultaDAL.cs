using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;

namespace Persistencia
{
    public class ConsultaDAL
    {
        private EFContext context;

        public IList<Consulta> TodasAsConsultas()
        {
            using (var context = new EFContext())
            {
                return context.Consultas.ToList<Consulta>();
            }
        }

        public IList<Consulta> FiltrarPorIdConsulta(string id)
        {
            using (var context = new EFContext())
            {

                return context.Consultas.Where(c => c.ConsultaId.ToString().Contains(id)).ToList();
            }
        }

        public IList<Consulta> FiltrarPorData(string data)
        {
            using (var context = new EFContext())
            {
                return context.Consultas.Where(c => c.DataConsulta.ToString().Contains(data)).ToList();
            }
        }


        public void AtualizarPrecoConsulta(Consulta consulta)
        {
            using (var context = new EFContext())
            {
                context.Consultas.Update(consulta);
                context.SaveChanges();
            }
        }

        public long GravarConsulta(Consulta consulta)
        {
            using (var context = new EFContext())
            {
                context.Consultas.Add(consulta);
                context.SaveChanges();
                return consulta.ConsultaId;
            }
        }

        public void EditarConsulta(Consulta consulta)
        {
            using (var context = new EFContext())
            {
                context.Update(consulta);
                context.SaveChanges();
            }
        }

    }
}
