using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Modelos.Abstractas
{
    public abstract class Evaluacion
    {
        
        public int Id { get; set; }
        public int NumeroEvaluacion { get; set; }
        public int CursoId { get; set; }
    }
}
