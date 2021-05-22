using SSC.Modelos;
using SSC.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Servicios
{
    public class ServicioCurso: Servicio<Curso>
    {
        private readonly RepositorioCurso Repositorio;
        public ServicioCurso()
        {
            Repositorio = new RepositorioCurso();
        }

        public Curso ObtenerUnCurso(string nombreCurso)
        {
            return this.Repositorio.ObtenerUnCurso(nombreCurso);
;
        }
    }
}
