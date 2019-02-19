using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj tekst: ");
            string text = Console.ReadLine();

            usingInstance(text);
            usingStaticMethod(text);

            StringStatistics.clearList();
            StringStatistics.printList();

            Console.ReadLine();
        }

        static void usingStaticMethod(string text)
        {
            Dictionary<int, int> lettersList = StringStatistics.statisticsOfStringStat(text);

            foreach (KeyValuePair<int, int> iter in lettersList)
            {
                Console.WriteLine((char)iter.Key + " " + iter.Value);
            }
        }

        static void usingInstance(string text)
        {
            StringStatistics instance = new StringStatistics();
            Dictionary<int, int> lettersListDyn = instance.statisticsofStringDyn(text);
            foreach (KeyValuePair<int, int> iter in lettersListDyn)
            {
                Console.WriteLine((char)iter.Key + " " + iter.Value);
            }
        }
    }
}
