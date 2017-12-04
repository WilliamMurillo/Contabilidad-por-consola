
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contabilidad
{
    public class nominacs
    {
        public float neto, deducciones2, basico, devengado, deducciones;
        public string nombre;
        public int dias;

        public nominacs()
        {
            neto = 0;
            devengado = 0;
            deducciones = 0;
            nombre = "''";
            dias = 0;
            basico = 0;
            deducciones2 = 0;
        }

        public void obtenerNombre(string nom)
        {
            nombre = nom;
        }
        public void MostrarNombre()
        {
            Console.Write(nombre);
        }

        public void obtenerValores()
        {
            Console.WriteLine("ingrese el numero de dias laborados");
            dias = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ingrese el salario basico mensual");
            basico = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el porcentaje de las deducciones (numero)");
            deducciones = float.Parse(Console.ReadLine());
            deducciones2 = deducciones;
            devengado = (basico/30) * dias;

            deducciones = deducciones / 100;

            neto = devengado - (devengado *deducciones);
        }
        public void mostrarBasico()
        {
            Console.Write(basico);
        }
        public void mostrarNeto()
        {
            Console.Write(neto);
        }

        public void mostrarDevengado()
        {
             Console.Write(devengado);
        }
        public void mostrarDeducciones() 
        {
            Console.Write(deducciones2);
        }
        public void mostrarDias()
        {
            Console.Write(dias);
        }
}
}
