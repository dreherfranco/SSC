using SSC.Servicios;
using System;

namespace SSC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0: Mostrar Cursos \n1:Cargar un nuevo Curso \n2:Cargar Capitulos a un curso\n3:Cargar Evaluaciones a un curso \n4:Salir");

            var servicioCurso = new ServicioCurso();
            var cursos = servicioCurso.ObtenerTodos();
            foreach (var curso in cursos)
            {
                Console.WriteLine($"nombre: {curso.Nombre}\ncosto: {curso.Costo}");
                foreach (var capitulo in curso.Capitulos)
                {
                    Console.WriteLine($"\ncapitulo: {capitulo.Tema}, Descripcion: {capitulo.Descripcion}");
                }
                foreach (var evaluacionPractica in curso.EvaluacionesPracticas)
                {
                    Console.WriteLine($"\nsituacion: {(evaluacionPractica.Aprobado ? "aprobado" : "desaprobado")}");
                }
                foreach (var evaluacionTeorica in curso.EvaluacionesTeoricas)
                {
                    Console.WriteLine($"\ncalificacion: {evaluacionTeorica.Calificacion}, nroEvaluacion: {evaluacionTeorica.NumeroEvaluacion}");
                }
            }
            int leer = Console.Read();
            while (leer != 4)
            {
                switch (leer)
                {
                    case 0:
                        //var servicioCursos = new ServicioCursos();
                        //cursos = servicioCursos.getCursos();
                        //muestro cursos
                        break;
                    case 1:
                        // Console.WriteLine("\nIngrese el nombre del curso: ");
                        // string nombreCurso = Console.ReadLine();
                        // Console.WriteLine("\nIngrese nombre del instructor: ");
                        // string instructor = Console.ReadLine();
                        // var servicioCurso = new ServicioCursos();
                        //servicioCurso.Agregar(nombreCurso, instructor);
                        break;
                    case 2:
                        //LISTAR CURSOS
                        //var servicioCursos = new ServicioCursos();
                        //cursos = servicioCursos.getCursos();

                        // Console.WriteLine("IdCurso\tNombreCurso ");
                        //for(int i=0; i<cursos.Count ;i++){
                        // Console.WriteLine($"\n{i}\tcursos[i].Nombre ");
                        //}


                        // Console.WriteLine("Ingrese el id del curso al cual quiere agregar un capitulo: ");
                        //  
                        //   while (idCurso < 0 || idCurso > cursos.Count)
                        //  {
                        //int idCurso = Console.Read();
                        //   }
                        // string nombreCurso = cursos[idCurso].Nombre;

                        // Console.WriteLine("\nTema del capitulo : ");
                        // string tema = Console.ReadLine();
                        //  Console.WriteLine("\nDescripcion del capitulo: ");
                        // string descripcion = Console.ReadLine();
                        // var servicioCapitulo = new ServicioCapitulo();
                        // servicioCapitulo.Agregar(nombreCurso,tema, descripcion);
                        break;
                    case 3:
                        break;
                }
                leer = Console.Read();
            }


        }
    }
}
