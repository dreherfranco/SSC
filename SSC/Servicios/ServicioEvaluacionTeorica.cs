using SSC.Modelos;
using SSC.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Servicios
{
    class ServicioEvaluacionTeorica : Servicio<EvaluacionTeorica>
    {
        private readonly RepositorioEvaluacionTeorica Repositorio;

        public ServicioEvaluacionTeorica()
        {
            Repositorio = new RepositorioEvaluacionTeorica();
        }

        public List<EvaluacionTeorica> EvaluacionesTeoricasDeUnCurso(string nombreCurso)
        {
            return Repositorio.ObtenerEvaluacionesTeoricasDeUnCurso(nombreCurso);
        }
    }
}
