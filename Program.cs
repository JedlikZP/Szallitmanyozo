using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Órai0221
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teljes = { "ABC-123", "QWE-456", "JKL-678", "BNM-789", "ASD-125", "LOK-783", "LPO-445", "JRT-767" };
            List<string> bent = new List<string>();
            string választás;
            do
            {
                Console.WriteLine("Elmegy (E)");
                Console.WriteLine("Bejön (B)");
                Console.WriteLine("Kilépés (K)");
                választás = Console.ReadLine();

                switch (választás)
                {
                    case "E": Elmegy(teljes); break;
                    case "B": Bejön(teljes,bent); break;
                    case "K": Kilépés(); break;
                    default: Console.WriteLine("Nem megfelelő választás!"); break;
                }

            } while (választás != "K");

            Console.ReadKey();
        }
        static string Bejön(string[]teljes, List<string> bent)
        {
            do
            {
                Console.Write("Kérem a rendszámot: ");
                string adottrendszám = Console.ReadLine();
                Console.Write("Ha kiszeretne lépni, írjon be K betűt.");
                if (bent.Contains(adottrendszám))
                {
                    Console.WriteLine("Ez a jármű már beérkezett! ");
                }
                else
                {
                    bent.Add(adottrendszám);
                }
            } while (Console.ReadLine("K"));
        }
    }
}
