using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace locker.Models
{
    public enum genero
    {
        masculino, femenino
    }

    public class Contacto
    {
        public int ContactoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime Fechanac { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime Fechareg { get; set; }
        public genero? genero { get; set; }
        public string sugerencias { get; set; }
        public string ip { get; set; }
    }
}