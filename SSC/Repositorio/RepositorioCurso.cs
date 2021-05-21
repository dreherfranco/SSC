using Microsoft.EntityFrameworkCore;
using SSC.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Repositorio
{
    public class RepositorioCurso: Repositorio<Curso>
    {
        public RepositorioCurso() : base() 
        { 
        }

        public async Task<Curso> ObtenerUnCurso(string nombre)
        {
           return await Contexto.Cursos.FirstOrDefaultAsync(x => x.Nombre == nombre);
        }

    }
}
