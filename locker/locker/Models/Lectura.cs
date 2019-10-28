using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace locker.Models
{
    public class Lectura
    {
        public int Id { get; set; }
        public string Libro { get; set; }
        public int Avance { get; set; }
    }
}