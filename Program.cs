using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Napišite program koji će ispisati sve prijestupne godine u razdoblju od(uključujući) 1900. do (uključujući)2100.Prijestupne godine su one koje su djeljive sa 400 
             plus one koje su djeljive sa 4, ali ne i sa 100.*/
            
            /*for(int j=1900;j<=2100 ;j++)
            {
                if (j % 400 ==0 || j % 4 ==0)
                {
                    Console.WriteLine(j);
                    
                }
            }

            Console.ReadKey();

            /*2.Napišite program koji će za unešeni niz znakova pronaći znak koji se pojavljuje najviše puta,
            te će i izračunati taj broj(npr.VODOVOD -> O, 3 puta).*/

            /*string str;
            int[] ch_fre = new int[255];
            int i = 0, max, l;
            int ascii;
            str = Console.ReadLine();
            l = str.Length;

            for (i = 0; i < 255; i++)
            {
                ch_fre[i] = 0;
            }

            i = 0;
            while (i < l)
            {
                ascii = (int)str[i];
                ch_fre[ascii] += 1;

                i++;
            }

            max = 0;
            for (i = 0; i < 255; i++)
            {
                if (i != 32)
                {
                    if (ch_fre[i] > ch_fre[max])
                        max = i;
                }
            }
            Console.Write("{0}, {1}", (char)max, ch_fre[max]);

            Console.ReadKey();

            /*3. Napišite program koji će zatražiti od korisnika da unese dva broja, te će izračunati najveći broj s kojim su oba broja djeljiva.*/

            /*Console.WriteLine("Upisi te dva broja");
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());
            int[] list = { a, b };
            int min_broj = list.Min();
            int max_djeljiv = 0;
            for (int k=1; k<=min_broj; k++)
            {
                if(a % k ==0 && b % k == 0)
                {
                    max_djeljiv = k;
                }
            }

            Console.WriteLine(max_djeljiv);

            Console.ReadKey();

            /*4. Napišite program koji će zatražiti od korisnika da unese neki pozitivni broj, te će ispisati sve brojeve manje od tog broja 
            na sljedeći način: npr. za unešeni broj 5 treba ispisati:
            1
            12
            123
            1234*/

            Console.WriteLine("Upisi te jedan pozitivan broj");
            int broj = Convert.ToInt32(Console.ReadLine());
            int[] polje = new int[broj]; 
            for(int o = 0; o<broj-1; o++)
            {
                polje[o] = o+1;
                for(int u = 0; u<=o; u++)
                {
                    Console.Write(polje[u]);
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
