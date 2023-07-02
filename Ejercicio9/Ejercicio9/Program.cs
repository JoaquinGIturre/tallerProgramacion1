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
            int usuario, contraseña, intentos;
            int cantidadUsuarios, nuevaLongitud;
            int codigoElegido;

            usuario = 0;
            contraseña = 0;
            intentos = 0;
            //MATRIZ DE DATOS DE CLIENTES X CODIGO CLIENTE.
            Int32[,] datosClientesXCodigoCliente = { {  4587, 3157 , 5968 ,  3485 ,  1687 },
                                                     { 12000, 3500 ,    0 , 14000 , 15750 }};
            cantidadUsuarios = datosClientesXCodigoCliente.GetLength(1);



            Console.WriteLine("----------------------------");
            Console.WriteLine("   BIENVENIDO AL CAJERO     ");
            Console.WriteLine("----------------------------");
            Console.Write("Usuario:");
            usuario = int.Parse(Console.ReadLine());
            if (usuario > datosClientesXCodigoCliente.GetLength(1))
            {
                intentos++;
                Console.WriteLine("Ingresaste un usuario incorrecto, intente nuevamente.");
                Console.WriteLine($"Intento:{intentos}/3");
            }
            Console.Write("Contraseña:");
            contraseña = int.Parse(Console.ReadLine());



            //Verificacion de datos.
            if (datosClientesXCodigoCliente[0, usuario] == contraseña)
            {
                //Codigo que se debe ejecutar cuando se hayan validado los datos.
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Bienvenido usuario:{usuario}");
                Console.WriteLine("Ingresa un codigo para continuar");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1-Deposito");
                Console.WriteLine("2-Extracción");
                Console.WriteLine("3-Saldo");
                Console.WriteLine("4-Transferencia");
                Console.WriteLine("8-Creación de nuevo usuario");
                codigoElegido = int.Parse(Console.ReadLine());

                switch (codigoElegido)
                {
                    case 1:
                        int repetir;
                        repetir = 0;
                        do
                        {
                            int saldoADepositar;
                            saldoADepositar = 0;
                            Console.Clear();
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("         DEPOSITO           ");
                            Console.WriteLine("----------------------------");
                            Console.Write("Ingrese monto a depositar:$");
                            saldoADepositar = int.Parse(Console.ReadLine());
                            datosClientesXCodigoCliente[1, usuario] += saldoADepositar;
                            Console.WriteLine($"Deposito exitoso, el nuevo saldo es ${datosClientesXCodigoCliente[1, usuario]}");
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("1-Hacer otro deposito.");
                            Console.WriteLine("2-Volver a menu principal.");
                            Console.WriteLine("----------------------------");
                            repetir = int.Parse(Console.ReadLine());
                        } while (repetir == 1);
                        codigoElegido = 0;
                        break;
                    case 2:
                        int saldoAExtraer;
                        saldoAExtraer = 0;
                        Console.Clear();
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("        Extracción          ");
                        Console.WriteLine("----------------------------");
                        Console.Write("Ingrese monto a extraer:$");
                        saldoAExtraer = int.Parse(Console.ReadLine());
                        datosClientesXCodigoCliente[1, usuario] -= saldoAExtraer;
                        Console.WriteLine($"Extracción exitosa, el nuevo saldo es ${datosClientesXCodigoCliente[1, usuario]}");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("          Saldo             ");
                        Console.WriteLine("----------------------------");
                        Console.Write($"El saldo actual es: ${datosClientesXCodigoCliente[1, usuario]}");
                        break;
                    case 4:
                        int auxSaldo, auxUsuarioDestino;
                        auxSaldo = 0;
                        auxUsuarioDestino = 0;
                        Console.Clear();
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("       Transferencia        ");
                        Console.WriteLine("----------------------------");
                        Console.Write("Saldo a transferir: $");
                        auxSaldo = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese codigo de usuario a transferir");
                        auxUsuarioDestino = int.Parse(Console.ReadLine());
                        //Agregar validacion de contraseña,saldo disponible para transferir y reconfirmación de usuario a enviar.
                        datosClientesXCodigoCliente[1, auxUsuarioDestino] += auxSaldo;
                        datosClientesXCodigoCliente[1, usuario] -= auxSaldo;
                        Console.WriteLine($"Nuevos saldos:{datosClientesXCodigoCliente[1, auxUsuarioDestino]}");
                        Console.WriteLine($"Nuevos saldos:{datosClientesXCodigoCliente[1, usuario]}");
                        break;
                    case 8:
                        int nuevoUsuario, nuevaContraseña;
                        nuevoUsuario = 0;
                        nuevaContraseña = 0;
                        //Se crea nueva matriz con 1 posición adicional.
                        nuevaLongitud = datosClientesXCodigoCliente.GetLength(1) + 1;
                        int[,] datosClientesXCodigoCliente2 = new int[datosClientesXCodigoCliente.GetLength(0), nuevaLongitud];
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
                            Console.WriteLine($"USUARIO:{i},CONTRASEÑA:{datosClientesXCodigoCliente2[0, i]}");
                        }
                        break;

                    default:
                        Console.WriteLine("Ingresaste un codigo incorrecto.");
                        break;
                }
            }
            else
            {
                {
                    intentos++;
                    Console.WriteLine("Usuario o contraseña incorrectos, intente nuevamente.");
                    Console.WriteLine($"Intento:{intentos}/3");
                }
                Console.ReadKey();
            }
        }
    }
}