using System;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Asignatura asignatura = new Asignatura();

            try
            {
                Console.WriteLine("Ingrese los datos del alumno:");
                Console.Write("Nombre: ");
                asignatura.NombreAlumno = Console.ReadLine();

                Console.Write("Número de Cuenta: ");
                asignatura.NumeroCuenta = Console.ReadLine();

                Console.Write("Email: ");
                asignatura.Email = Console.ReadLine();

                Console.WriteLine("\nIngrese los datos de la asignatura:");
                Console.Write("Nombre de la Asignatura: ");
                asignatura.NombreAsignatura = Console.ReadLine();

                Console.Write("Horario: ");
                asignatura.Horario = Console.ReadLine();

                Console.Write("Nombre del Docente: ");
                asignatura.NombreDocente = Console.ReadLine();

                bool notaValida = false;
                do
                {
                    try
                    {
                        Console.Write("\nIngrese la nota del primer parcial (0-30): ");
                        asignatura.N1 = int.Parse(Console.ReadLine());
                        if (asignatura.N1 < 0 || asignatura.N1 > 30)
                            throw new Exception("La nota del primer parcial debe estar entre 0 y 30.");

                        Console.Write("Ingrese la nota del segundo parcial (0-30): ");
                        asignatura.N2 = int.Parse(Console.ReadLine());
                        if (asignatura.N2 < 0 || asignatura.N2 > 30)
                            throw new Exception("La nota del segundo parcial debe estar entre 0 y 30.");

                        Console.Write("Ingrese la nota del tercer parcial (0-40): ");
                        asignatura.N3 = int.Parse(Console.ReadLine());
                        if (asignatura.N3 < 0 || asignatura.N3 > 40)
                            throw new Exception("La nota del tercer parcial debe estar entre 0 y 40.");

                        notaValida = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Debe ingresar un número entero.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                } while (!notaValida);

                Console.WriteLine("\nDatos del alumno y asignatura:");
                asignatura.Imprimir();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error general: {ex.Message}");
            }
        }
    }
}
