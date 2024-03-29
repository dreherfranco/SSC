﻿using SSC.Modelos;
using SSC.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SSC.Servicios
{
    public class ServicioCapitulo: Servicio<Capitulo>
    {
        private readonly Repositorio<Capitulo> Repositorio;
        public ServicioCapitulo()
        {
            Repositorio = new Repositorio<Capitulo>();
        }

        public List<Capitulo> CapitulosDeUnCurso(string nombreCurso)
        {
            Expression<Func<Capitulo, bool>> filtro = x => x.Curso.Nombre == nombreCurso;
            return this.Repositorio.Obtener(filtro);
        }
    }
}
