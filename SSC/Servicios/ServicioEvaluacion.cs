using SSC.Modelos;
using SSC.Modelos.Abstractas;
using SSC.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Servicios
{
    public class ServicioEvaluacion: Servicio<Evaluacion>
    {
        private readonly RepositorioEvaluacion Repositorio;
        public ServicioEvaluacion()
        {
            Repositorio = new RepositorioEvaluacion();
        }

        public  List<EvaluacionPractica> EvaluacionesPracticasDeUnCurso(string nombreCurso)
        {
            return Repositorio.ObtenerEvaluacionesPracticasDeUnCurso(nombreCurso);
        }

        public  List<EvaluacionTeorica> EvaluacionesTeoricasDeUnCurso(string nombreCurso)
        {
            return Repositorio.ObtenerEvaluacionesTeoricasDeUnCurso(nombreCurso);
        }
    }
}
