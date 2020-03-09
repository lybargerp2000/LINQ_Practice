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
            List<string> wordsWithTH = words.Where(s => s.Contains("th")).ToList();
            foreach (var word in wordsWithTH)
            {
                Console.WriteLine(word);
              
            }
            Console.ReadLine();


            List<string> names = new List<string> { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            IEnumerable<string> result = names.Distinct();
            foreach(var sn in result)
            {
                Console.WriteLine(sn);
            }
            Console.ReadLine();

            List<string> classGrades = new List<string>() {"80,100,92,89,65",
             "93,81,78,84,69",
             "73,88,83,99,64",
             "98,100,66,74,55"};
            var result = 

        }
    }
}
