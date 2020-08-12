using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_mayores
{
    class Program
    {
        Mayores ma = new Mayores();
        static void Main(string[] args)
        {
            int v1 = 10, v2 = 20, v3 = 30, v4 = 40, v5 = 50, v6 = 60, v7 = 70, v8 = 80, v9 = 90, v10 = 1000;
            int resultado = 0;

            resultado = ma.MayorAB(ma.MayorAB(ma.MayorAB(ma.MayorAB(ma.MayorAB(ma.MayorAB(ma.MayorAB(ma.MayorAB(v1, v2)ma.MayorAB(v3, v4), v5),v6),v7),v8),v9),v10));
            Console.WriteLine("El mayor es:" + resultado);
            Console.ReadKey();
        }
    }
}
