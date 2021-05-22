using SSC.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Servicios
{
    public class Servicio<TEntidad> where TEntidad : class
    {
        private readonly Repositorio<TEntidad> Repositorio;
        public Servicio()
        {
            Repositorio = new Repositorio<TEntidad>();
        }

        public void Agregar(TEntidad entidad)
        {
            Repositorio.Agregar(entidad);
        }

        public List<TEntidad> ObtenerTodos()
        {
            return Repositorio.ObtenerTodos();
        }
    }
}
