using SSC.Modelos;
using SSC.Servicios;
using System;
using System.Collections.Generic;

namespace SSC
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("0: Mostrar Cursos \n1:Cargar un nuevo Curso \n2:Cargar Capitulos a un curso\n3:Cargar Evaluaciones a un curso\n4: Mostrar Capitulos de un curso \n5:Mostrar todas las evaluaciones de un curso\n6:Salir\n");
            int leer = int.Parse(Console.ReadLine());

            var servicioCapitulo = new ServicioCapitulo();
            var servicioCursos = new ServicioCurso();
            var servicioEvaluacionPractica = new ServicioEvaluacionPractica();
            var servicioEvaluacionTeorica = new ServicioEvaluacionTeorica();
            List<Curso> cursos;
            int idCurso;
            Curso curso;

            while (leer >=0 || leer <= 5)
            {
                switch (leer)
                {
                    case 0:
                        ListarCursos();
                        break;
                    case 1:
                         Console.WriteLine("\nIngrese el nombre del curso: ");
                         string nombreCurso = Console.ReadLine();
                         Console.WriteLine("\nIngrese nombre del instructor: ");
                         string instructor = Console.ReadLine();
                        Console.WriteLine("\nIngrese costo del curso: ");
                        float costo = float.Parse(Console.ReadLine());

                        servicioCursos.Agregar(new Curso() { Nombre = nombreCurso, Instructor=instructor, Costo=costo});
                        break;
                    case 2:
  
                         cursos = ListarCursos();

                        idCurso = SeleccionarId(cursos.Count);

                         Console.WriteLine("\nTema del capitulo : ");
                         string tema = Console.ReadLine();
                          Console.WriteLine("\nDescripcion del capitulo: ");
                         string descripcion = Console.ReadLine();

                       
                         servicioCapitulo.Agregar(new Capitulo() {  CursoId = idCurso, Tema= tema, Descripcion = descripcion });
                        break;
                    case 3:
                        cursos = ListarCursos();

                        idCurso = SeleccionarId(cursos.Count);

                        char tipoEvaluacion;
                        do
                        {
                            Console.WriteLine("\nCARGAR EVALUACION\nIngrese T si la evaluacion es teorica sino ingrese P para evaluaciones practicas ");
                            tipoEvaluacion = char.ToUpper(Convert.ToChar(Console.ReadLine()));  
                            
                        } while (!tipoEvaluacion.Equals('T') && !tipoEvaluacion.Equals('P'));

                       
                        if (tipoEvaluacion.Equals('P'))
                        {
                            char condicion;
                            do
                            {
                                Console.WriteLine("\nIngrese A para aprobado y D para desaprobado: ");
                                condicion = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                            } while (!condicion.Equals('A') && !condicion.Equals('D'));

                            bool aprobado = condicion == 'A' ? true : false;

                            
                            servicioEvaluacionPractica.Agregar(new EvaluacionPractica() { CursoId= idCurso, Aprobado = aprobado });

                        }
                        else
                        {
                            Console.WriteLine("\nIngrese la calificacion:");
                            int calificacion = int.Parse(Console.ReadLine());

                           
                            servicioEvaluacionTeorica.Agregar(new EvaluacionTeorica() { Calificacion = calificacion, CursoId = idCurso });
                        }
                        break;
                    case 4:
                        cursos = ListarCursos();

                        idCurso = SeleccionarId(cursos.Count);
                        curso = cursos.Find(x => x.Id == idCurso);

                        var capitulos = servicioCapitulo.CapitulosDeUnCurso(curso.Nombre);

                        foreach (var capitulo in capitulos)
                        {
                            Console.WriteLine($"\nTEMA: {capitulo.Tema}\t DESCRIPCION: {capitulo.Descripcion}");
                        }
                        break;
                    case 5:
                        cursos = ListarCursos();

                        idCurso = SeleccionarId(cursos.Count);
                        curso = cursos.Find(x => x.Id == idCurso);

                        var evaluacionesTeoricas = servicioEvaluacionTeorica.EvaluacionesTeoricasDeUnCurso(curso.Nombre);

                        Console.WriteLine($"\nEvaluaciones teoricas del curso {cursos[idCurso].Nombre}");
                        foreach(var evaluacion in evaluacionesTeoricas)
                        {
                            Console.WriteLine($"\nNumero de Evaluacion: {evaluacion.NumeroEvaluacion}\t Calificacion: {evaluacion.Calificacion}");
                        }

                        var evaluacionesPracticas = servicioEvaluacionPractica.EvaluacionesPracticasDeUnCurso(curso.Nombre);
                        Console.WriteLine($"\nEvaluaciones practicas del curso {cursos[idCurso].Nombre}");
                        foreach (var evaluacion in evaluacionesPracticas)
                        {
                            Console.WriteLine($"\nNumero de Evaluacion: {evaluacion.NumeroEvaluacion}\t Aprobado: { (evaluacion.Aprobado ? "Si" : "No") }");
                        }

                        break;
                }
                Console.WriteLine("0: Mostrar Cursos \n1:Cargar un nuevo Curso \n2:Cargar Capitulos a un curso\n3:Cargar Evaluaciones a un curso\n4: Mostrar Capitulos de un curso \n5:Mostrar todas las evaluaciones de un curso\n6:Salir\n");                leer = int.Parse(Console.ReadLine());
            }


        }


        private static List<Curso> ListarCursos()
        {
            var servicioCursos = new ServicioCurso();
            var cursos = servicioCursos.ObtenerTodos();
            Console.WriteLine("\nIdCurso\tNombreCurso\tInstructor ");
            for (int i = 0; i < cursos.Count; i++)
            {
                Console.WriteLine($"\n{cursos[i].Id}\t{cursos[i].Nombre}\t{cursos[i].Instructor} ");
            }
            return cursos;
        }

        private static int SeleccionarId(int cantidadCursos)
        {
            int idCursoElegido;
            do
            {
                Console.WriteLine("\nIngrese el id del curso : ");
                idCursoElegido = int.Parse(Console.ReadLine());
            } while (idCursoElegido < 0 || idCursoElegido > cantidadCursos);

            return idCursoElegido;

        }
    }

}
