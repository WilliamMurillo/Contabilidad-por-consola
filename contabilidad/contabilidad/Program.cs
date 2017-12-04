
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//hacer el libro diario y el balance general 
namespace contabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            libroDiario uno = new libroDiario();
            balanceGeneral dos = new balanceGeneral();
            nominacs tres = new nominacs();
            int a = 0, b, c;

            Console.WriteLine("Ingrese 1 para usar el libro diario");
            Console.WriteLine("Ingrese 2 para usar el balance general");
            Console.WriteLine("Ingrese 3 para usar nomina");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("             BIENVENIDO A SU LIBRO DIARIO ");
                    b = 0;
                    while (a == 0)
                    {

                        Console.WriteLine("ingrese el numero 1 para registrar un saldo en credito o ");
                        Console.WriteLine("ingrese el numero 2 para registrar un saldo en debito");
                        uno.cambiarNum(int.Parse(Console.ReadLine()));

                        Console.WriteLine("ingrese el valor a registrar");
                        uno.cambiarValor(Convert.ToDouble(Console.ReadLine()));
                        //registrar valor
                        uno.registrarValor();
                        Console.WriteLine("ingrese cero ( 0 ) para ingresar mas saldos ");
                        Console.WriteLine("ingrese otro numero para salir del libro diario");
                        Console.WriteLine("y ver sus saldos");
                        b = int.Parse(Console.ReadLine());

                    }
                    Console.WriteLine("SUS SALDOS SON ");
                    Console.WriteLine("en debito =");
                    uno.retornarDebito();
                    Console.WriteLine("en credito = ");
                    uno.retornarCredito();

                    break;
                case 2:
                    // BALANCE GENERAL
                    Console.WriteLine("            BIENVENIDO AL BALANCE GENERAL");
                    Console.WriteLine("recuerde que los activos son todos los bienes que tiene una entidad ");
                    Console.WriteLine("y que los pasivos son todas las obligaciones que tiene esta con sus acreedores");
                    Console.WriteLine("el patrimonio es el valor neto de lo que le pertenece a la empresa");
                    Console.WriteLine("");
                     c = 0;

                    while (c == 0)
                    {
                        Console.WriteLine("ingrese 1 para registar activos");
                        Console.WriteLine("ingrese 2 para registar pasivos ");
                        dos.cambiarNum(int.Parse(Console.ReadLine()));
                        //registrar las cuentas
                        Console.WriteLine("ingrese el valor a registrar");
                        dos.cambiarValor(Convert.ToDouble(Console.ReadLine()));
                        dos.registrarCuenta();
                        Console.WriteLine("ingrese cero ( 0 ) para ingresar mas saldos");
                        Console.WriteLine("ingrese otro numero para saliry saber sus valores");
                   
                        c = int.Parse(Console.ReadLine());
                    }
                    
                    Console.WriteLine("el total de sus activos =");
                    dos.retornarActivos();
                    Console.WriteLine("el total de sus pasivos =");
                    dos.retornarPasivos();
                    Console.WriteLine("  SU PATRIMONIO ES =");
                    dos.obtenerPatrimonio();

                    break;
                case 3:

                    Console.WriteLine("BIENVENIDO A LA NOMINA ");

                    Console.WriteLine("Ingrese el nombre del trabajador ");
                    tres.obtenerNombre(Console.ReadLine());
                    tres.obtenerValores();

                    Console.Write("El empleado ");
                    tres.MostrarNombre();
                    Console.Write(" con un salario basico de ");
                    tres.mostrarBasico();
                    Console.Write(" devenga ");
                    tres.mostrarDevengado();
                    Console.Write(" para un total de ");
                    tres.mostrarDias();
                    Console.Write(" dias laborados, tiene unas deducciones totales de ");
                    tres.mostrarDeducciones();
                    Console.Write("% su salario NETO es = ");
                    tres.mostrarNeto();
                    break;
            }

         
         

            Console.ReadKey();
        }
    }
}
