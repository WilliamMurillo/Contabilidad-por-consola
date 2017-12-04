
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contabilidad
{

    public class libroDiario
    {

        public double saldoDebito, saldoCredito, valor;
        public int num;

        public libroDiario()
        {
            num = 0;
            valor = 0;
            saldoCredito = 0;
            saldoDebito = 0;
        }
        public libroDiario(double debito, double credito, int n, double valor)
        {
            this.valor = valor;
            this.num = n;
            this.saldoCredito = credito;
            this.saldoDebito = debito;
        }

        public void cambiarNum(int num)
        {
            this.num = num;

        }

        public void cambiarValor(double valor)
        {
            this.valor = valor;
        }

        public void registrarValor()
        {


            if (num == 1)
            {

                this.saldoCredito = this.saldoCredito + valor;

            }
            else if (num == 2)
            {

                saldoDebito = this.saldoDebito + valor;

            }
            else if (num != 1 && num != 2)
            {

                Console.WriteLine("ingresó un valor no valido ");

            }

        }

        public void retornarDebito()
        {

            Console.WriteLine(saldoDebito);

        }
        public void retornarCredito()
        {

            Console.WriteLine(saldoCredito);

        }

    }
}