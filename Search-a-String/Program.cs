using System;

namespace Search_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string AIW = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string input;
            string lowerAIW = AIW.ToLower(); //convert all to lowercase
            string[] arrOfLowerAIW = lowerAIW.Split(' '); //split string on blanks

            Console.WriteLine(AIW);
            Console.WriteLine("\n Enter a word to be searched in above sentence.");
            input = Console.ReadLine();

            for (int i=0; i < arrOfLowerAIW.Length; i++)
            {
                if (input.ToLower() == arrOfLowerAIW[i])
                {
                    Console.WriteLine("true");
                }
            }

        }
    }
}
