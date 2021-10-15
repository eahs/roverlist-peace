using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words
            RoverList<string> list = new RoverList<string>();
            string[] words = {"dog", "cat", "horse", "rabbit", "parrot", "eagle", 
                "tiger", "lion", "zebra", "lizard", "mouse", "spider", "fish", "dolphin", "panther", "falcon"}; 
            
            foreach (string word in words)
            {
                list.Add(word);
            }

            // TODO:  Print out the list
            list.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list
            string input = "";
            
            Console.WriteLine("Input words to the end of the list. Type 'done' to finish.");
            while (input != "done")
            {
                Console.Write("Type word: ");
                input = Console.ReadLine();
                list.Add(input);
            }
            
            list.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list
            Console.WriteLine("Input words to the front of the list. Type 'done' to finish.");
            
            while (input != "done")
            {
                Console.Write("Type word: ");
                input = Console.ReadLine();
                list.Add(0, input);
            }
            
            list.ListNodes();
            
            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list
            for (int i = 0; i < list.Count; i++)
            {
                string word = list.ElementAt(i);
                int length = word.Length;
                if (length % 2 == 1)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            
            list.ListNodes();

            // TODO:  Clear the list
            // TODO:  Print out the list
            list.Clear();
            list.ListNodes();

        }

        
    }
}
