using locker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace locker.DAL
{
    public class LockerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LockerContext>
    {
        protected override void Seed(LockerContext context)
        {
            var students = new List<Contacto>
            {
            new Contacto { ContactoID = 1, Nombre = "Alexander", Apellido = "nio", Fechanac = DateTime.Parse("2005-09-01"), Fechareg = DateTime.Parse("2005-09-01"),genero = genero.masculino,sugerencias=",uy bien",ip="2344"},
            };

            students.ForEach(s => context.Contactos.Add(s));
            context.SaveChanges();

        }
    }
}