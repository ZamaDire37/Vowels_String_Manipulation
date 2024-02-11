using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels__String_manipulations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            Console.WriteLine("Enter 10 words:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Word {i + 1}: ");
                string word = Console.ReadLine();
                words.Add(word);
            }

            // Sort the words in alphabetical order
            words.Sort();

            Console.WriteLine("\nSorted Words:");

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {words[i]}");
            }

            Console.Write("\nEnter the number of the word to count vowels: ");
            int selectedWordNumber = int.Parse(Console.ReadLine());

            if (selectedWordNumber >= 1 && selectedWordNumber <= words.Count)
            {
                string selectedWord = words[selectedWordNumber - 1];
                int vowelCount = CountVowels(selectedWord);

                Console.WriteLine($"\nThe word \"{selectedWord}\" contains {vowelCount} vowels.");
            }
            else
            {
                Console.WriteLine("Invalid selection. Please choose a valid number.");
            }
            Console.ReadLine();
        }

        static int CountVowels(string word)
        {
            int count = 0;
            foreach (char c in word.ToLower())
            {
                if ("aeiou".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
        
    }
}