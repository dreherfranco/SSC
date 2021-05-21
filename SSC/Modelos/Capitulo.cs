using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Modelos
{
    public class Capitulo
    {
        public int Id { get; set; }
        public string NombreCurso { get; set; }
        public string Tema { get; set; }
        public string Descripcion { get; set; }
        public Curso Curso { get; set; }
    }
}
