using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadUsuarios,nuevaLongitud;
            int codigoElegido;
            int nuevoUsuario,nuevaContraseña;
            
            nuevoUsuario = 0;
            nuevaContraseña = 0;
            Int32[,] datosClientesXCodigoCliente = { {  4587, 3157 , 5968 ,  3485 ,  1687 },
                                                     { 12000, 3500 ,    0 , 14000 , 15750 }};
            cantidadUsuarios = datosClientesXCodigoCliente.GetLength(1);
            Console.WriteLine("8-Creación de nuevo usuario");
            codigoElegido = int.Parse(Console.ReadLine());
            if (codigoElegido == 8)
            {
                //Se crea nueva matriz con 1 posición adicional.

                nuevaLongitud = datosClientesXCodigoCliente.GetLength(1) + 1;
                int[,] datosClientesXCodigoCliente2 = new int[datosClientesXCodigoCliente.GetLength(0) , nuevaLongitud ];
                Console.WriteLine("CREACION DE NUEVO USUARIO");
                Console.WriteLine("-------------------------");
                nuevoUsuario = nuevaLongitud;
                Console.WriteLine($"Tu usuario asignado es {nuevoUsuario - 1}");
                Console.WriteLine($"Usuario:{nuevoUsuario - 1}");
                Console.Write("Contraseña:");
                nuevaContraseña = int.Parse(Console.ReadLine());


                //Ciclo repetitivo para poblar el nuevo array.
                for (int f = 0; f < datosClientesXCodigoCliente.GetLength(0); f++)
                {
                    for (int c = 0; c < datosClientesXCodigoCliente.GetLength(1); c++)
                    {
                        datosClientesXCodigoCliente2[f, c] = datosClientesXCodigoCliente[f, c];
                    }
                }
                datosClientesXCodigoCliente2[0, nuevoUsuario - 1] = nuevaContraseña;

                //Ciclo repetitivo para mostrar el nuevo array.
                for (int i = 0; i < datosClientesXCodigoCliente2.GetLength(1); i++)
                {
                        Console.WriteLine($"USUARIO:{i},CONTRASEÑA:{datosClientesXCodigoCliente2[0,i]}");
                }




            }





            Console.ReadKey();
        }
    }
}
