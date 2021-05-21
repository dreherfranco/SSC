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
        private RepositorioCurso Repositorio;
        public ServicioCurso()
        {
            Repositorio = new RepositorioCurso();
        }

        public async Task<Curso> ObtenerUnCurso(string nombreCurso)
        {
            return await this.Repositorio.ObtenerUnCurso(nombreCurso);
;
        }
    }
}
