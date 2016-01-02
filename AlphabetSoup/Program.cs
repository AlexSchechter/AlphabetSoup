using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetSoup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
            List<char> orderedString = MakeAlphabetSoup(Console.ReadLine());
            orderedString.ForEach(Console.Write);
            Console.ReadKey();
        }

        private static List<char> MakeAlphabetSoup(string word)
        {
            List<char> wordAsList = word.ToList();
            wordAsList.Sort();
            return wordAsList;
        }

    }
}
