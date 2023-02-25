using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_16_02_23;

namespace APP_arreglos_personasC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero_contactos = 0;
            Console.WriteLine("=====AGENDA DE PERSONAS=====\n");
            Console.Write("Ingrese la cantidad de contactos que quiere agregar: ");
            numero_contactos = int.Parse(Console.ReadLine());
            Contac[] Personas = new Contac[numero_contactos];
            Console.Clear();
            for (int i = 0; i < numero_contactos; i++)
            {
                Console.WriteLine("=====CONTACTO =====\n");
                Contac Agenda = new Contac();
                Console.Write("Ingresa el Nombre: ");
                Agenda.Nombre = Console.ReadLine();
                Console.Write("Ingresa tu Apellido paterno: ");
                Agenda.Apellido_Paterno = Console.ReadLine();
                Console.Write("Ingresa el Apellido materno: ");
                Agenda.Apellido_Materno = Console.ReadLine();
                Console.Write("Ingresa tu Fecha de cumpleaños (DD/MM/AAAA): ");
                Agenda.Fecha_de_cumpleaños = DateTime.Parse(Console.ReadLine());
                Console.Write("Ingresa tu Correo: ");
                Agenda.Correo = Console.ReadLine();
                Console.Write("Ingresa tu Telefono: ");
                Agenda.Telefono = Console.ReadLine();
                Personas[i] = Agenda;
                Console.Clear();
            }

            for (int i = 0; i < numero_contactos; i++)
            {
                Console.WriteLine("Contacto #"+(i+1));
                Console.WriteLine(Personas[i].ToString() + "\n");
            }
            Console.WriteLine("Pulse entre para salir...");
            Console.ReadKey();
        }
    }
}