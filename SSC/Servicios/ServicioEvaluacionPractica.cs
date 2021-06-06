using SSC.Modelos;
using SSC.Modelos.Abstractas;
using SSC.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Servicios
{
    public class ServicioEvaluacionPractica: Servicio<EvaluacionPractica>
    {
        private readonly Repositorio<EvaluacionPractica> Repositorio;
        public ServicioEvaluacionPractica()
        {
            Repositorio = new Repositorio<EvaluacionPractica>();
        }

        public  List<EvaluacionPractica> EvaluacionesPracticasDeUnCurso(string nombreCurso)
        {
            Expression<Func<EvaluacionPractica, bool>> filtro = x => x.Curso.Nombre == nombreCurso;
            return Repositorio.Obtener(filtro);
        }

        
    }
}
