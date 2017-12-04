
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contabilidad
{
    public class balanceGeneral : libroDiario
    {
        double activos, pasivos;

        public balanceGeneral()
        {

            activos = 0;
            pasivos = 0;
        }
        public balanceGeneral(double pasivo, double activo)
        {

            this.activos = activo;
            this.pasivos = pasivo;
        }


        public void registrarCuenta()
        {
            if (this.num == 1)
            {
                activos = activos + this.valor;
            }
            else if (this.num == 2)
            {
                pasivos = pasivos + this.valor;
            }
        }
        public void retornarActivos()
        {
            Console.WriteLine(this.activos);
        }
        public void retornarPasivos()
        {
            Console.WriteLine(this.pasivos);
        }
        public void obtenerPatrimonio()
        {
            Console.WriteLine(this.activos - this.pasivos);
        }

    }
}