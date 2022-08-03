using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFC_Beta
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string FechaNac = "00/00/0000";
            string ApeM, ApeP, Nombre, r;
            //DateTime DATENam;
            do
            {
                Console.WriteLine("¿Cual es tu nombre? (EN MAYUSCULAS)");
                Nombre = Console.ReadLine();

                Console.WriteLine("¿Cual es tu apellido Paterno? (EN MAYUSCULAS)");
                  
                ApeP = Console.ReadLine();

                Console.WriteLine("¿Cual es tu apellido Materno? (EN MAYUSCULAS)");
                ApeM = Console.ReadLine();

                Console.WriteLine("¿Cual es tu Fecha de Nacimiento? (dd/mm/yyyy)");
                FechaNac = Console.ReadLine();
                DateTime DATENam = DateTime.ParseExact(FechaNac, "dd/MM/YYYY", null);

                //DATENam = DateTime.Parse(Console.ReadLine());









                Console.WriteLine("¿Desea continuar con otro RFC de otra persona? SI/NO");
                r = Console.ReadLine();

                Console.Clear();

            } while (r == "N0");
            Console.WriteLine("Gracias por usar este programa!!!!");
            Console.ReadKey();

            Environment.Exit(0);


        }
        public static void ApE_M(string ApM)
        {

        }
    }
}