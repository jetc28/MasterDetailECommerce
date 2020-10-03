using MasterDetailECommerce.Web.Data;
using MasterDetailECommerce.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterDetailECommerce.Web.Helpers
{
    public class CombosHelper : IDisposable
    {
        private static ApplicationDbContext db = new ApplicationDbContext();

        public static List<Departament> GetDepartaments()
        {
            var departament = db.Departaments.ToList();
            departament.Add(new Departament
            {
                Id = 0,
                Name = "(Seleccione departamento...)",
            });
            return departament.OrderBy(d => d.Name).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
