using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int vowelsCount(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length -1; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || )
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            Console.WriteLine(vowelsCount(word));
        }
    }
}
