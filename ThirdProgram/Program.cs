using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ThirdProgram
{
    
    class Program
    {
        static decimal saldoApertura;
        static decimal saldoCuenta;

        static void Main(string[] args)
        {
            char salida = ' ';

            do
            {
                int opc = ' ';
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1. Ingresar informacion ");
                Console.WriteLine("2. Realizar consignacion ");
                Console.WriteLine("3. Realizar retiro ");
                Console.WriteLine("4. Consultar saldo ");
                Console.WriteLine("5. Salir ");
                Console.Write("Ingrese una opcion: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1: informacionCliente();break;
                    case 2: consignacion();break;
                    case 3: retiro(); break;
                    //case 4: consulta(); break;
                    case 5: break;
                    default:
                        break;
                }
                Console.Write("PARA SALIR PRESIONE (S) DE LO CONTRARIO PRESIONE (N): " );
                salida = char.Parse(Console.ReadLine());
                Console.Clear();

            } while (salida == 'n'|| salida == 'N' );
        }

        public static void informacionCliente()
        {
            string nombre;
            double numeroCuenta;

            Console.WriteLine("INFORMACION FINANCIERA");
            Console.WriteLine("Completar la siguiente informacion:");

            Console.Write("Nombres y apellidos: ");
            nombre = Console.ReadLine();

            Console.Write("Numero de cuenta: ");
            numeroCuenta = double.Parse(Console.ReadLine());

            Console.Write("Ingrese valor de apertura: ");
            saldoApertura = decimal.Parse(Console.ReadLine());
            
        }

        public static void consignacion()
        {
            
            decimal consignacion = 0;
            Console.WriteLine("CONSIGNACION");

            Console.Write("Monto a consignar: ");
            consignacion = decimal.Parse(Console.ReadLine());
            saldoCuenta = saldoApertura + consignacion;

            Console.WriteLine("CONSIGNACION EXITOSA");
            Console.WriteLine(saldoCuenta);
        
            Console.ReadKey();
        }

        public static void retiro ()
        {
            
            decimal retiro = 0;
            Console.WriteLine("RETIRO");

            Console.Write("Monto a retirar: ");
            retiro = decimal.Parse(Console.ReadLine());
            saldoCuenta = saldoApertura - retiro;

            Console.WriteLine("RETIRO EXITOSO");
            Console.WriteLine(saldoCuenta);

            Console.ReadKey();
            
        }

    }
}
