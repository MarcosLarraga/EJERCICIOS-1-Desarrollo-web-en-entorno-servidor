using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Diccionario que almacena las calificaciones de los estudiantes
        Dictionary<string, Dictionary<string, double>> estudiantes = new Dictionary<string, Dictionary<string, double>>
        {
            { "Juan", new Dictionary<string, double> { { "Matemáticas", 85 }, { "Historia", 90 } } },
            { "María", new Dictionary<string, double> { { "Matemáticas", 95 }, { "Ciencias", 88 } } },
            { "Pedro", new Dictionary<string, double> { { "Ciencias", 78 }, { "Historia", 85 } } } // Nuevo estudiante
        };

        // Datos para modificar
        string nombreEstudiante = "Pedro"; // Cambié a "Pedro"
        string asignatura = "Ciencias"; // Asignatura existente
        double nuevaCalificacion = 80; // Nueva calificación

        // Modificar la calificación
        ModificarCalificacion(estudiantes, nombreEstudiante, asignatura, nuevaCalificacion);
        
        // Ejemplo de intentar modificar una asignatura no registrada
        string otraAsignatura = "Matemáticas"; // Asignatura no registrada para Pedro
        ModificarCalificacion(estudiantes, nombreEstudiante, otraAsignatura, 90);
    }

    static void ModificarCalificacion(Dictionary<string, Dictionary<string, double>> estudiantes, string nombreEstudiante, string asignatura, double nuevaCalificacion)
    {
        // Verificamos si el estudiante existe
        if (estudiantes.ContainsKey(nombreEstudiante))
        {
            // Obtenemos las calificaciones del estudiante
            var calificaciones = estudiantes[nombreEstudiante];

            // Verificamos si la asignatura existe
            if (calificaciones.ContainsKey(asignatura))
            {
                // Modificamos la calificación
                calificaciones[asignatura] = nuevaCalificacion;
                Console.WriteLine($"La calificación de {nombreEstudiante} en {asignatura} se ha modificado a {nuevaCalificacion}.");
            }
            else
            {
                // Mensaje de error si la asignatura no existe
                Console.WriteLine($"Error: {nombreEstudiante} no tiene registrada la asignatura {asignatura}.");
            }
        }
        else
        {
            // Mensaje de error si el estudiante no existe
            Console.WriteLine($"Error: No se encontró al estudiante {nombreEstudiante}.");
        }
    }
}
