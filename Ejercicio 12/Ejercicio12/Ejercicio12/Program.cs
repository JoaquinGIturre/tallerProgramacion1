using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de constantes.
            const int precioAuto = 150;
            const int precioCamionetas = 200;
            const int precioCamiones = 320;



            //Declaracion de variables.
            int codigoElegido;
            int recaudacionAutos;
            int recaudacionCamionetas;
            int recaudacionCamiones;
            int recaudacionTotal;
            int vecesAutos;
            int vecesCamionetas;
            int vecesCamiones;
            int vecesTotales;



            //Inicialización de variables.
            recaudacionAutos = 0;
            recaudacionCamionetas = 0;
            recaudacionCamiones = 0;
            recaudacionTotal = 0;
            vecesAutos = 0;
            vecesCamionetas = 0;
            vecesCamiones = 0;
            vecesTotales = 0;



            //Elegimos un ciclo do-while, para que se ejecute al menos 1 vez el código.
            do
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Bienvenido al peaje, inserte un codigo para continuar.");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine($"1-Registrar Auto.(${precioAuto})");
                Console.WriteLine($"2-Registrar Camioneta.(${precioCamionetas})");
                Console.WriteLine($"3-Registrar Camion.(${precioCamiones})");
                Console.WriteLine("0-Finalizar.");
                Console.WriteLine("------------------------------------------------------");
                codigoElegido = Int16.Parse(Console.ReadLine());

                //Hacemos un proceso de verificación del codigo ingresado por parte del usuario.



                if (codigoElegido != 0 && codigoElegido != 1 && codigoElegido != 2 && codigoElegido != 3)
                {
                    Console.Clear();
                    Console.WriteLine("Ingresaste un codigo incorrecto, intente nuevamente.");
                    Console.ReadKey();
                }



                if (codigoElegido == 1)
                {
                    recaudacionAutos += 150;
                }
                else if (codigoElegido == 2)
                {
                    recaudacionCamionetas += 200;
                }
                else if (codigoElegido == 3)
                {
                    recaudacionCamiones += 320;
                }

                recaudacionTotal = recaudacionAutos + recaudacionCamionetas + recaudacionCamiones;
                vecesAutos = recaudacionAutos / 150;
                vecesCamionetas = recaudacionCamionetas / 200;
                vecesCamiones = recaudacionCamiones / 320;
                vecesTotales = vecesAutos + vecesCamionetas + vecesCamiones;



                //Devolucion de datos para el usuario.
                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine($"La recaudacion total es: ${recaudacionTotal}, el total de vehiculos que ingresaron es {vecesTotales}");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine("Porcentajes");
                Console.WriteLine($"Autos:%{vecesAutos * 100 / vecesTotales}");
                Console.WriteLine($"Camionetas:%{vecesCamionetas * 100 / vecesTotales}");
                Console.WriteLine($"Camiones:%{vecesCamiones * 100 / vecesTotales}");
                Console.WriteLine("------------------------------------------------------------------------------------------ ");
                Console.WriteLine($"Autos:${recaudacionAutos}, {vecesAutos} totales.");
                Console.WriteLine($"Camionetas:${recaudacionCamionetas}, {vecesCamionetas} totales.");
                Console.WriteLine($"Camiones:${recaudacionCamiones}, {vecesCamiones} totales.");



            } while (codigoElegido != 0);
            if (codigoElegido == 0)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------------------ ");
                Console.WriteLine("Elegiste el codigo 0, finalizando programa.");
                Console.WriteLine("------------------------------------------------------------------------------------------ ");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine($"La recaudacion total es: ${recaudacionTotal}, el total de vehiculos que ingresaron es {vecesTotales}");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine("Porcentajes");
                Console.WriteLine($"Autos:%{vecesAutos * 100 / vecesTotales}");
                Console.WriteLine($"Camionetas:%{vecesCamionetas * 100 / vecesTotales}");
                Console.WriteLine($"Camiones:%{vecesCamiones * 100 / vecesTotales}");
                Console.WriteLine("------------------------------------------------------------------------------------------ ");
                Console.WriteLine($"Autos:${recaudacionAutos}, {vecesAutos} totales.");
                Console.WriteLine($"Camionetas:${recaudacionCamionetas}, {vecesCamionetas} totales.");
                Console.WriteLine($"Camiones:${recaudacionCamiones}, {vecesCamiones} totales.");
                Console.ReadKey();
            }
        }
    }
}