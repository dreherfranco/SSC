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
    public class RepositorioEvaluacionTeorica: Repositorio<EvaluacionTeorica>
    {
        public RepositorioEvaluacionTeorica(): base()
        {
        }
       /* public new void Agregar(EvaluacionTeorica evaluacion)
        {
            Contexto.EvaluacionesTeoricas.Add(evaluacion);
            Contexto.SaveChangesAsync();
        }*/
        public List<EvaluacionTeorica> ObtenerEvaluacionesTeoricasDeUnCurso(string nombreCurso)
        {
            return this.Contexto.EvaluacionesTeoricas.Where(x => x.Curso.Nombre == nombreCurso).ToList();
        }
    }
}
