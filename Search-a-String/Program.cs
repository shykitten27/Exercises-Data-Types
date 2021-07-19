using System;

namespace Search_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine(alice);
            Console.WriteLine("\nEnter a word to be searched in above sentence.");
            string searchTerm = Console.ReadLine();
            string completeSearchTerm = searchTerm.ToLower(); //convert all to lowercase
            string completeAlice = alice.ToLower(); //convert all to lowercase
    
            int foundIndex = completeAlice.IndexOf(completeSearchTerm, 0);
            Console.WriteLine("\nThe search term " + searchTerm + ", can be found at " + foundIndex + ".");
            Console.WriteLine("\nThe search term is " + searchTerm.Length + " characters long.");

            string newAlice = alice.Remove(foundIndex, searchTerm.Length);
            Console.WriteLine(newAlice);
        }
    }
}
