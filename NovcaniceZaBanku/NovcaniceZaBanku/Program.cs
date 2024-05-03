using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovcaniceZaBanku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napisite ceo broj n: ");
            int n = int.Parse(Console.ReadLine());
            int[] niz = new int[n];
            int duzina=1, pocetak=0,maxDuzina=0,maxPocetak=0;
            string brojevi="";

            for (int i = 0; i < n; i++) niz[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < niz.Length-1;i++)
            {
                if (niz[i]<niz[i+1]) { duzina += 1;}
                else 
                {
                    pocetak = i+1;
                    duzina = 1;
                }
                if (maxDuzina < duzina) 
                {
                    maxDuzina = duzina;
                    maxPocetak = pocetak;
                    
                }
            }
            for (int i = 0; i < maxDuzina; i++)
            {
                brojevi=brojevi + niz[maxPocetak + i].ToString();
            }


            Console.WriteLine("Najveca rastuca duzina niza je " + maxDuzina + " i pocinje na " + maxPocetak+". mestu u nizu, ti brojevi su "+brojevi);
            
            Console.ReadLine();
        }
    }
}
