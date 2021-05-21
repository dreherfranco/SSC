using Microsoft.EntityFrameworkCore;
using SSC.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Repositorio
{
    public class RepositorioCapitulo : Repositorio<Capitulo>
    {
        public RepositorioCapitulo() : base()
        {
        }

        public async Task<List<Capitulo>> ObtenerTodosLosCapitulosDeUnCurso(string nombreCurso)
        {
            return await this.Contexto.Capitulos
                .Where(x => x.NombreCurso == nombreCurso)
                .ToListAsync() ;
        }
    }
}
