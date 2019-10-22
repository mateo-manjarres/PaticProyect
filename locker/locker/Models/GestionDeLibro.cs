using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace locker.Models
{
    public class GestionDeLibro
    {
        //Cada 100 paginas un arbol
        public int pag, arbol = 0;
        public int GestionDeLibroID { get; set; }
        [Display(Name = "Nombre del libro")]
        public string NombreLibro { get; set; }
        public string Estado { get; set; }
        public string Autor { get; set; }
        public string Introduccion { get; set; }
        public string Genero { get; set; }
        public string Editorial { get; set; }
        [Display(Name = "Pagina actual")]
        public int PaginaActual
        {
            get
            {
                return pag;
            }
            set
            {
                pag = value;
            }
        }
        public int Arboles
        {
            get
            {
                arbol = 0;
                for (int i = 0;  i<pag; i=i+100)
                {
                    arbol +=1;
                }
                return arbol;
            }
            set
            {
                arbol = value;
            }
        }
      
    }
}