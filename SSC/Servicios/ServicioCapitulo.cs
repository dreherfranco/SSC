using SSC.Modelos;
using SSC.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Servicios
{
    public class ServicioCapitulo: Servicio<Capitulo>
    {
        private readonly RepositorioCapitulo Repositorio;
        public ServicioCapitulo()
        {
            Repositorio = new RepositorioCapitulo();
        }

        public List<Capitulo> CapitulosDeUnCurso(string nombreCurso)
        {
            return this.Repositorio.ObtenerTodosLosCapitulosDeUnCurso(nombreCurso);
        }
    }
}
