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
            WordLibrary wordLibrary = new WordLibrary();
            List<Word> words = wordLibrary.GetWords();
            List<Word> wordsWithTH = words.Contains("th");
            foreach (var word in wordsWithTH)
            {
                Console.WriteLine(word.word);
            }
        }
    }
}
