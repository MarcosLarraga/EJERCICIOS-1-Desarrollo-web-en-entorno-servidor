using System;
using System.Collections.Generic;
//EJERCICIO 2

class Estudiante
{
    public string Nombre { get; set; }

    public Estudiante(string nombre)
    {
        Nombre = nombre;
    }
}

class ProgramaEducativo
{
    private List<Estudiante> estudiantes;

    public ProgramaEducativo()
    {
        estudiantes = new List<Estudiante>();
    }

    // Método para agregar un nuevo estudiante
    public void AgregarEstudiante(string nombre)
    {
        estudiantes.Add(new Estudiante(nombre));
        Console.WriteLine($"El estudiante {nombre} ha sido agregado.");
    }

    // Método para eliminar un estudiante por su nombre
    public void EliminarEstudiante(string nombre)
    {
        // Buscar al estudiante por nombre
        Estudiante estudianteAEliminar = estudiantes.Find(e => e.Nombre == nombre);

        if (estudianteAEliminar != null)
        {
            // Si se encuentra, eliminar el estudiante
            estudiantes.Remove(estudianteAEliminar);
            Console.WriteLine($"El estudiante {nombre} ha sido eliminado.");
        }
        else
        {
            // Si no se encuentra, mostrar mensaje de error
            Console.WriteLine($"Error: El estudiante {nombre} no se encuentra en el sistema.");
        }
    }

    // Método para listar todos los estudiantes
    public void ListarEstudiantes()
    {
        Console.WriteLine("Lista de estudiantes:");
        foreach (Estudiante estudiante in estudiantes)
        {
            Console.WriteLine(estudiante.Nombre);
        }
    }
}

class Program
{
    static void Main()
    {
        ProgramaEducativo programa = new ProgramaEducativo();

        // Agregar algunos estudiantes
        programa.AgregarEstudiante("Juan");
        programa.AgregarEstudiante("María");
        programa.AgregarEstudiante("Pedro");

        // Listar los estudiantes
        programa.ListarEstudiantes();

        // Intentar eliminar un estudiante existente
        programa.EliminarEstudiante("María");

        // Intentar eliminar un estudiante que no existe
        programa.EliminarEstudiante("Luis");

        // Listar los estudiantes después de la eliminación
        programa.ListarEstudiantes();
    }
}
