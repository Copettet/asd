using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite koliko imate razlicitih novcanih vrednosti n>");
            int n = int.Parse(Console.ReadLine());
            int[] niz = new int[n*2];
            for (int i = 0; i < n * 2; i+=2)
            {
                Console.WriteLine("Velicina novcanice:"); 
                niz[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Koliko imate tih novcanica od " + niz[i]+" dinara");
                niz[i+1] = int.Parse(Console.ReadLine());
            }

            for (int i = 0;i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }
            

            Console.WriteLine("Upisite vrednost koju zelite da isplatite");
            int m = int.Parse(Console.ReadLine());
            int trenutnoStanje= m;
            int promenjiva=0;
            


            for (int i = 0; i < n*2; i+=2)
            {
                promenjiva = 0; ;
                while (trenutnoStanje > niz[i] &&  promenjiva!=niz[i])
                {
                    promenjiva++;
                    trenutnoStanje -= niz[i];
                    
                }
                


            }
            if (trenutnoStanje == 0) Console.WriteLine("Isplata je uspesna");
            else Console.WriteLine("Isplata ne moze da prodje zato sto nemate !TACNU! novcanu vrednost fali vam " +trenutnoStanje+" dinara");

            Console.ReadLine();
        }
    }
}
