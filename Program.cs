using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string usuario = "usuario"; // Cambia esto por el nombre de usuario deseado
        string contraseña = "contraseña123"; // Cambia esto por la contraseña deseada

        Console.WriteLine("Por favor, ingrese su nombre de usuario:");
        string usuarioIngresado = Console.ReadLine();

        Console.WriteLine("Por favor, ingrese su contraseña:");
        string contraseñaIngresada = Console.ReadLine();

        if (usuarioIngresado == usuario && contraseñaIngresada == contraseña)
        {
            Console.WriteLine("¡Inicio de sesión exitoso!");
        }
        else
        {
            Console.WriteLine("Nombre de usuario o contraseña incorrectos. Por favor, inténtelo nuevamente.");
        }

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}
