using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARACION DE VARIABLES.
            int usuario, contraseña, intentos;
            bool sesionIniciada;
            //INCIALIZACIÓN DE VARIABLES.
            usuario = 0;
            contraseña = 0;
            intentos = 0;
            sesionIniciada = false;
            
            //MATRIZ DE DATOS DE CLIENTES X CODIGO CLIENTE.
            Int32[,] datosClientesXCodigoCliente = { {  4587, 3157 , 5968 ,  3485 ,  1687 },
                                                     { 12000, 3500 ,    0 , 14000 , 15750 }};

            // Generamos un ciclo repetitivo que mientras la cantidad de intentos sea menor que "3" se ejecute el codigo.
            while (intentos < 3)
            {
                //Etapa de Login.
                Console.Clear();
                Console.WriteLine("----------------------------");
                Console.WriteLine("   BIENVENIDO AL CAJERO     ");
                Console.WriteLine("----------------------------");
                //Se solicita a usuario que ingrese su numero de cliente/usuario.
                Console.Write("Usuario:");
                usuario = int.Parse(Console.ReadLine());
                //Almacenamos el valor ingresado por usuario en variable "usuario".

                //1era verificación, verificaremos si es que el codigo de cliente podria llegar a estar en nuestra matriz, si el 
                //usuario que indica usuario es mayor al numero de columnas, es un usuario inexistente, por ende sumamos "1" a la
                //variable contadora de intentos.
                if (usuario > datosClientesXCodigoCliente.GetLength(1) - 1)
                {
                    intentos++;
                    Console.WriteLine("Ingresaste un usuario invalido, intente nuevamente.");
                    Console.WriteLine($"Intento:{intentos}/3");
                    Console.ReadKey();
                }
                else
                {
                    //Una vez que verificamos que el usuario este correcto consultamos la contraseña.
                    Console.Write("Contraseña:");
                contraseña = int.Parse(Console.ReadLine());
                //Sabemos que la contraseña esta almacenada en la fila 0 y en la columna correspondiente al numero de columna,
                if (datosClientesXCodigoCliente[0, usuario] == contraseña)
                {
                //Si el numero de usuario y la contraseña coinciden, podemos permitir el acceso a menu principal, lo registramos con
                //una variable de tipo bool llamada sesionIniciada, le asignamos el valor true.
                    sesionIniciada = true;
                        int codigoElegido;
                        codigoElegido = 0;

                        //Generamos un ciclo while, que evalue la condición de la variable sesionIniciada.
                        //Mientras que este en estado true, va a mostrar el menu, esto nos ayudará a volver al menu principal después de cada seleccion de submenues.
                        while (sesionIniciada)
                        {
                            intentos = 0; // Una vez iniciado sesión se reinicia la variable contadora de intentos.
                            Console.Clear();
                            Console.WriteLine("----------------------------");                     
                            Console.WriteLine($"Bienvenido usuario: {usuario}.");
                            Console.WriteLine("Ingresa un codigo para continuar");
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("1-Deposito");
                            Console.WriteLine("2-Extracción");
                            Console.WriteLine("3-Saldo");
                            Console.WriteLine("4-Transferencia");
                            Console.WriteLine("8-Creación de nuevo usuario");
                            Console.WriteLine("0-Cerrar sesión.");
                            Console.WriteLine("----------------------------");
                            codigoElegido = int.Parse(Console.ReadLine());

                            int repetir; // Esta variable nos permitira repetir el codigo de cada caso.
                            repetir = 0;
                            switch (codigoElegido)
                            {
                                case 1:
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
                                        Console.WriteLine("Cualquier tecla para regresar a menu principal.");
                                        Console.WriteLine("----------------------------");
                                        repetir = Convert.ToInt32(int.Parse(Console.ReadLine()));
                                    } while (repetir == 1);
                                    break;
                                case 2:
                                    int saldoAExtraer;
                                    saldoAExtraer = 0;
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("----------------------------");
                                        Console.WriteLine("        Extracción          ");
                                        Console.WriteLine("----------------------------");
                                        Console.Write("Ingrese monto a extraer:$");
                                        saldoAExtraer = int.Parse(Console.ReadLine());
                                        while (saldoAExtraer > datosClientesXCodigoCliente[1, usuario])
                                        {
                                            Console.WriteLine("Saldo insuficiente, intenta nuevamente.");
                                            Console.Write("Monto a extraer:$");
                                            saldoAExtraer = int.Parse(Console.ReadLine());
                                        }
                                    datosClientesXCodigoCliente[1, usuario] -= saldoAExtraer;
                                    Console.WriteLine($"Extracción exitosa, el nuevo saldo es ${datosClientesXCodigoCliente[1, usuario]}");
                                    Console.WriteLine("----------------------------");
                                    Console.WriteLine("1-Hacer otra extracción.");
                                    Console.WriteLine("Cualquier tecla para regresar a menu principal.");
                                    Console.WriteLine("----------------------------");
                                    repetir = int.Parse(Console.ReadLine());
                                    } while (repetir == 1);
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("----------------------------");
                                    Console.WriteLine("          Saldo             ");
                                    Console.WriteLine("----------------------------");
                                    Console.WriteLine($"El saldo actual es: ${datosClientesXCodigoCliente[1, usuario]}");
                                    Console.WriteLine("Presione una tecla para volver al menú principál.");
                                    Console.ReadKey();
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
                                    while (auxSaldo > datosClientesXCodigoCliente[1,usuario])
                                    {
                                        Console.WriteLine("Saldo insuficiente, intenta nuevamente.");
                                        Console.Write("Monto a transferir:$");
                                        saldoAExtraer = int.Parse(Console.ReadLine());
                                    }
                                    Console.Write("Ingrese codigo de usuario a transferir");
                                    auxUsuarioDestino = int.Parse(Console.ReadLine());
                                    while(auxUsuarioDestino > datosClientesXCodigoCliente.GetLength(1)-1)
                                    {
                                        Console.WriteLine("Usuario invalido, intente nuevamente.");
                                        Console.Write("Codigo de usuario:");
                                        auxUsuarioDestino = int.Parse((Console.ReadLine()));
                                    }
                                    //Agregar validacion de contraseña,saldo disponible para transferir y reconfirmación de usuario a enviar.
                                    datosClientesXCodigoCliente[1, auxUsuarioDestino] += auxSaldo;
                                    datosClientesXCodigoCliente[1, usuario] -= auxSaldo;
                                    Console.WriteLine($"Nuevos saldos cuenta destino:{datosClientesXCodigoCliente[1, auxUsuarioDestino]}");
                                    Console.WriteLine($"Nuevos saldos cuenta origen:{datosClientesXCodigoCliente[1, usuario]}");
                                    Console.WriteLine("Presione una tecla para volver al menú principál.");
                                    Console.ReadKey();
                                    break;
                                /*case 8:
                                    int nuevoUsuario, nuevaContraseña,nuevaLongitud;
                                    nuevoUsuario = 0;
                                    nuevaContraseña = 0;
                                    nuevaMatriz = 1;
                                    Console.WriteLine(nuevaMatriz);
                                    Console.ReadKey();
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
                                    //Ciclo repetitivo para reemplazar el viejo array por el nuevo.
                                    for (int f = 0; f < datosClientesXCodigoCliente2.GetLength(0); f++)
                                    {
                                        for (int c = 0; c < datosClientesXCodigoCliente2.GetLength(1); c++)
                                        {
                                            datosClientesXCodigoCliente[f, c] = datosClientesXCodigoCliente2[f, c];
                                        }
                                    }
                                    for (int i = 0; i < datosClientesXCodigoCliente.GetLength(1); i++)
                                    {
                                        Console.WriteLine($"Usuario {i}, contraseña{datosClientesXCodigoCliente[0, usuario]}");
                                    }
                                    Console.ReadKey();
                                    break;*/
                                case 0:
                                    sesionIniciada = false;
                                    Console.WriteLine("Cerrando sesión.....");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Ingresaste un codigo incorrecto.");
                                    break;
                            }
                        }
                    } else
                    //Si el nombre de usuario es correcto, pero la contraseña no
                    //Aumentamos la variable contadora en "1"
                    {
                        intentos++;
                        Console.WriteLine("Ingresaste una contraseña invalida, intente nuevamente.");
                        Console.WriteLine($"Intento:{intentos}/3");
                        Console.ReadKey();
                    }
                } 
            } 
                if (intentos == 3) // Una vez que se superen los "3" intentos, va a ejectuar este codigo que sería la salida.
                {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine("Cantidad maxima de intentos utilizados,finalizando el programa....");
                    Console.ReadKey();
                }
            }
            }
        }
