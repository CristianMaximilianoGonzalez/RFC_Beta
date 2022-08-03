# RFC_Beta
C# 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectofinal
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
                DateTime DATENam = Convert.ToDateTime(FechaNac);
                //DATENam = DateTime.Parse(Console.ReadLine());
                apellido(Nombre, ApeP);
          







                Console.WriteLine("¿Desea continuar con otro RFC de otra persona? SI/NO");
                r = Console.ReadLine();

                Console.Clear();

            } while (r == "N0");
            Console.WriteLine("Gracias por usar este programa!!!!");
            Console.ReadKey();

            Environment.Exit(0);
        }
       public static void apellido (String x, String f) 
        {
            int posicion = 0;
            char l_ap_1, l_ap_2, nom;
            nom = char.ToUpper(char.Parse(x.Substring(0, 1)));
            l_ap_1 = char.ToUpper(char.Parse(f.Substring(0, 1)));
            char vocal = 'A';
            bool isfirst=true;
            foreach (char letra in f)// VARIABLE letra ALMACENARA POR CADA VUELTA LA LETRA DEL AP
            {
                if (isfirst == true)
                {
                    isfirst = false;
                    continue;
                }

                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

                if (vowels.Contains(letra) == true)
                {
                    vocal = letra; //en la variable vocal dejar el resultado de la busqueda
                    posicion = f.IndexOf(vocal);
                    break;
                }
                else
                {
                    posicion = 1;
                }
            }

            //Console.WriteLine(posicion);
            l_ap_2=char.ToUpper(char.Parse(f.Substring(posicion,1)));

            Console.WriteLine(l_ap_1 + "" + l_ap_2 + "" + nom);
            
        }
    }
}
