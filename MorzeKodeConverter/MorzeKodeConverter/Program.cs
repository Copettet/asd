using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorzeKodeConverter
{
    class Program
    {
        static Dictionary<string, string> slova = new Dictionary<string, string>();


        static void popunjavanje()
        {
            //slova.Add("acab", "//");
            slova.Add("a", ".- ");
            slova.Add("b", "-... ");
            slova.Add("c", "-.-. ");
            slova.Add("d", "-.. ");
            slova.Add("e", ". ");
            slova.Add("f", "..-. ");
            slova.Add("g", "--. ");
            slova.Add("h", ".... ");
            slova.Add("i", ".. ");
            slova.Add("j", ".--- ");
            slova.Add("k", "-.- ");
            slova.Add("l", ".-.. ");
            slova.Add("m", "-- ");
            slova.Add("n", "-. ");
            slova.Add("o", "--- ");
            slova.Add("p", ".--. ");
            slova.Add("q", "--.- ");
            slova.Add("r", ".-. ");
            slova.Add("s", "... ");
            slova.Add("t", "- ");
            slova.Add("u", "..- ");
            slova.Add("v", "...- ");
            slova.Add("w", ".-- ");
            slova.Add("x", "-..- ");
            slova.Add("y", "-.-- ");
            slova.Add("z", "--.. ");
        }
        static bool sadrziSpecijalneKaraktere;
        static bool HasSpecialChars(string yourString)
        {
            sadrziSpecijalneKaraktere = false;
            if (yourString.Any(ch => !char.IsLetterOrDigit(ch)) && yourString.All(ch =>! char.IsWhiteSpace(ch))) sadrziSpecijalneKaraktere = true;
            return sadrziSpecijalneKaraktere;
        }
        static void Main(string[] args)
        {
            popunjavanje();
            Console.WriteLine("Upisite vas string/recenicu koristeci englesku abecedu: ");
            string provera = Console.ReadLine();

            while (HasSpecialChars(provera))
            {
                Console.WriteLine("Karaktere koje ste unelu se ne nalaze u morzeovoj tabli :3 ");
                provera = Console.ReadLine();
                
            }
            /*int kvas = provera.Length; ovo je ako zelite da idete na https://morsecode.world/international/translator.html da testirate poz
            for (int i = 0; i < kvas; i++)
            {
                if (provera[i].ToString() == " ") { provera = provera.Insert((i + 1), "/"); i++; }
            }
            
            Console.WriteLine(provera);
            */

            provera = provera.ToUpper();
            foreach (var par in slova)
            {

                
                provera = provera.Replace(par.Key.ToUpper(), par.Value.ToUpper());

                


            }
            Console.WriteLine(provera);
            Console.ReadLine();

        }
    }
}
