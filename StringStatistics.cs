using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class StringStatistics
    {
        private static Dictionary<int, int> lettersCounter = new Dictionary<int, int>();

        static StringStatistics()
        {
            for (int i = 0; i < 129; i++)
            {
                lettersCounter.Add(i, 0);
            }
        }

        public static Dictionary<int, int> statisticsOfStringStat(string text)
        {
            for(int i=0; i<text.Length; i++)
            {
                char character = text[i];
                if (lettersCounter.ContainsKey((int)character) == true)
                {
                    lettersCounter[character] += 1;
                }
            }

            return lettersCounter;
        }

        public Dictionary<int, int> statisticsofStringDyn(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char character = text[i];
                if (lettersCounter.ContainsKey((int)character) == true)
                {
                    lettersCounter[character] += 1;
                }
            }

            return lettersCounter;
        }

        public static void clearList()
        {
            for (int i = 0; i < 129; i++)
            {
                if (lettersCounter.ContainsKey(i) == true)
                {
                    lettersCounter[i] = 0;
                }
            }
        }

        public static void printList()
        {
            foreach (KeyValuePair<int, int> iter in lettersCounter)
            {
                Console.WriteLine((char)iter.Key + " " + iter.Value);
            }
        }
    }
}
