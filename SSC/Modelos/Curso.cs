using SSC.Modelos.Abstractas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Modelos
{
    public class Curso
    {
        [Key]
        public string Nombre { get; set; }
        public string Instructor { get; set; }
        public List<Capitulo> Capitulos { get; set; }
        public List<EvaluacionPractica> EvaluacionesPracticas { get; set; }
        public List<EvaluacionTeorica> EvaluacionesTeoricas { get; set; }
    }
}
