using Microsoft.EntityFrameworkCore;
using SSC.Modelos;
using SSC.Modelos.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Repositorio
{
    public class RepositorioEvaluacion: Repositorio<Evaluacion>
    {
        public RepositorioEvaluacion(): base()
        {
        }

        public  List<EvaluacionPractica> ObtenerEvaluacionesPracticasDeUnCurso(string nombreCurso)
        {
            return this.Contexto.EvaluacionesPracticas.Where(x => x.Curso.Nombre == nombreCurso).ToList();
        }

        public List<EvaluacionTeorica> ObtenerEvaluacionesTeoricasDeUnCurso(string nombreCurso)
        {
            return this.Contexto.EvaluacionesTeoricas.Where(x => x.Curso.Nombre == nombreCurso).ToList();
        }
    }
}
