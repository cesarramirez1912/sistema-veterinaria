using Persistencia;

namespace Servico
{
    public class DataBaseCreate
    {
        public static void CreateDataBase()
        {
            using(EFContext ctx = new EFContext())
            {
                ctx.Database.EnsureCreated();
            }
        }
    }
}
