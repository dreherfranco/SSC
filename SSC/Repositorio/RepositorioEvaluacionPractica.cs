using SSC.Modelos;
using SSC.Modelos.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Repositorio
{
    public class RepositorioEvaluacionPractica: Repositorio<EvaluacionPractica>
    {
        public RepositorioEvaluacionPractica() : base()
        {
        }
        public List<EvaluacionPractica> ObtenerEvaluacionesPracticasDeUnCurso(string nombreCurso)
        {
            return this.Contexto.EvaluacionesPracticas.Where(x => x.Curso.Nombre == nombreCurso).ToList();
        }
    }
}
