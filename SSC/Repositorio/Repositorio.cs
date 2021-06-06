using Microsoft.EntityFrameworkCore;
using SSC.DbConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public void Agregar(T entity)
        {
            Contexto.Set<T>().Add(entity);
            Contexto.SaveChangesAsync();
        }

        public List<T> ObtenerTodos()
        { 
            return Contexto.Set<T>().ToList();
        }

    }
}
