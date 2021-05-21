using SSC.Modelos;
using SSC.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Servicios
{
    public class ServicioCurso
    {
        private Repositorio<ServicioCurso> Repositorio;
        public ServicioCurso()
        {
            Repositorio = new Repositorio<ServicioCurso>();
        }

     /*   public async Task<Curso> ObtenerUnCurso(string nombreCurso)
        {
            var cursos = this.Repositorio.Obtener();
;
        }*/
    }
}
