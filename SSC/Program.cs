using SSC.Modelos;
using SSC.Servicios;
using System;

namespace SSC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0: Mostrar Cursos \n1:Cargar un nuevo Curso \n2:Cargar Capitulos a un curso\n3:Cargar Evaluaciones a un curso \n4:Salir");

            
            int leer = int.Parse(Console.ReadLine());
            var servicioCursos = new ServicioCurso();
            while (leer >=0 || leer <= 4)
            {
                switch (leer)
                {
                    case 0:
                        
                        var cursos = servicioCursos.ObtenerTodos();
                        //muestro cursos
                        foreach(var curso in cursos)
                        {
                            Console.WriteLine($"\nNombre curso:{curso.Nombre}\tInstructor:{curso.Instructor}");
                        }
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
                        //LISTAR CURSOS                    
                        cursos = servicioCursos.ObtenerTodos();
                        
                        Console.WriteLine("\nIdCurso\tNombreCurso ");
                        for(int i=0; i<cursos.Count ;i++){
                            Console.WriteLine($"\n{i}\t{cursos[i].Nombre} ");
                        }

                        int idCurso;
                        do
                        {
                            Console.WriteLine("\nIngrese el id del curso al cual quiere agregar un capitulo: ");
                            idCurso = int.Parse(Console.ReadLine());
                        } while (idCurso < 0 || idCurso > cursos.Count);
                       
                         Console.WriteLine("\nTema del capitulo : ");
                         string tema = Console.ReadLine();
                          Console.WriteLine("\nDescripcion del capitulo: ");
                         string descripcion = Console.ReadLine();

                         var servicioCapitulo = new ServicioCapitulo();
                         servicioCapitulo.Agregar(new Capitulo() {  CursoId = idCurso, Tema= tema, Descripcion = descripcion });
                        break;
                    case 3:
                        //LISTAR CURSOS                    
                        cursos = servicioCursos.ObtenerTodos();

                        Console.WriteLine("\nIdCurso\tNombreCurso ");
                        for (int i = 0; i < cursos.Count; i++)
                        {
                            Console.WriteLine($"\n{i}\t{cursos[i].Nombre} ");
                        }

                        int idCursoElegido;
                        do
                        {
                            Console.WriteLine("\nIngrese el id del curso al cual quiere agregar una Evaluacion: ");
                            idCursoElegido = int.Parse(Console.ReadLine());
                        } while (idCursoElegido < 0 || idCursoElegido > cursos.Count);

                        char tipoEvaluacion;
                        do
                        {
                            Console.WriteLine("\nCARGAR EVALUACION\nIngrese T si la evaluacion es teorica sino ingrese P para evaluaciones practicas ");
                            tipoEvaluacion = char.ToUpper(Convert.ToChar(Console.ReadLine()));  
                            
                        } while (!tipoEvaluacion.Equals("T") || !tipoEvaluacion.Equals("P"));

                        ServicioEvaluacion servicioEvaluacion = new ServicioEvaluacion();
                        if (tipoEvaluacion.Equals("P"))
                        {
                            char condicion;
                            do
                            {
                                Console.WriteLine("\nIngrese A para aprobado y D para desaprobado: ");
                                condicion = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                            } while (!condicion.Equals("A") && !condicion.Equals("D"));

                            bool aprobado = condicion == 'A' ? true : false;
                            servicioEvaluacion.Agregar(new EvaluacionPractica() { CursoId= idCursoElegido, Aprobado = aprobado });

                        }
                        else
                        {
                            Console.WriteLine("\nIngrese la calificacion:");
                            int calificacion = int.Parse(Console.ReadLine());
                            servicioEvaluacion.Agregar(new EvaluacionTeorica() { Calificacion = calificacion, CursoId = idCursoElegido });
                        }
                        break;

                }
                Console.WriteLine("0: Mostrar Cursos \n1:Cargar un nuevo Curso \n2:Cargar Capitulos a un curso\n3:Cargar Evaluaciones a un curso \n4:Salir");
                leer = int.Parse(Console.ReadLine());
            }


        }
    }
}
