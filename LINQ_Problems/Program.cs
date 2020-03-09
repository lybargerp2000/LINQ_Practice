using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "the", "bike", "this", "it", "tenth", "mathematics" };
            //WordLibrary wordLibrary = new WordLibrary();
            //List<Word> words = wordLibrary.GetWords();
            List<string> wordsWithTH = words.Where(s => s.Contains("th")).ToList();
            foreach (var word in wordsWithTH)
            {
                Console.WriteLine(word);
              
            }
            Console.ReadLine();
        }
    }
}
