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
    public class ServicioEvaluacionPractica: Servicio<EvaluacionPractica>
    {
        private readonly RepositorioEvaluacionPractica Repositorio;
        public ServicioEvaluacionPractica()
        {
            Repositorio = new RepositorioEvaluacionPractica();
        }

        public  List<EvaluacionPractica> EvaluacionesPracticasDeUnCurso(string nombreCurso)
        {
            return Repositorio.ObtenerEvaluacionesPracticasDeUnCurso(nombreCurso);
        }

      
    }
}
