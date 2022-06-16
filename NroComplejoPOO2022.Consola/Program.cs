using System;
using NroComplejoPOO2022.Entidades;

namespace NroComplejoPOO2022.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Complex numbers!!");
            var nc = new NumeroComplejo(10, -5);
            var nc2=new NumeroComplejo(10,-5);
            var nc3 = nc + nc2;
            var nc4=new NumeroComplejo(1,2);
            var nc5 = nc - nc4;

            var nc6 = "10-2i";
            Console.WriteLine(nc6.ToString());
            Console.WriteLine(nc.ToString());
            Console.WriteLine(nc2.ToString());
            Console.WriteLine(nc3.ToString());
            Console.WriteLine(nc4.ToString());
            Console.WriteLine(nc5.ToString());
            if (nc==nc2)
            {
                Console.WriteLine("Ambos números son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }
        }
    }
}
