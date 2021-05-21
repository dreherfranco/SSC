using Microsoft.EntityFrameworkCore;
using SSC.DbConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Repositorio
{
    public class Repositorio<T> where T : class
    {
        protected readonly ApplicationDbContext Contexto;
        public Repositorio()
        {
            Contexto = new ApplicationDbContext();
        }

        public async Task Agregar(T entity)
        {
            Contexto.Set<T>().Add(entity);
            await Contexto.SaveChangesAsync();
        }

        public async Task<List<T>> ObtenerTodos()
        { 
            return await Contexto.Set<T>().ToListAsync();
        }


    }
}
