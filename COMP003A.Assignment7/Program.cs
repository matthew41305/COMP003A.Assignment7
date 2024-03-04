using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.Arm;

namespace COMP003A.Assignment7
    /* Author:Matthew Hudson
     * Course:COMP003A
     * Purpose: Arrays
     */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array - CharcteCounter Section
            SectionSeparator("Array - CharacterCounter Section ");
            Console.Write("Enter a letter: ");
            char userChar = char.Parse(Console.ReadLine());

            Console.Write("Please enter a word: ");
            string userWord = Console.ReadLine();

            int charCount = CharacterCounter(userChar, userWord);

           
            Console.WriteLine($"Character '{userChar}' appears {charCount} times in the word '{userWord}'");
          

            // Array - IsPalindrome Section 
            SectionSeparator("Array - IsPalindrome Section");
            Console.Write("Please enter a word to check if it is a Palindrome");
            string userPalindromeWord = Console.ReadLine();

            bool isPalindromeWord = IsPalindrome(userPalindromeWord);

           
            Console.WriteLine($"The word '{userPalindromeWord}' is {(isPalindromeWord ? "a palindrome" : "not a palindrome")}");
            

            // List - Add Section
            SectionSeparator("List - Add Section");

            List<string> names = new List<string>();
            char userInput = default;


            do
            {
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();
                names.Add(name);

                Console.Write("Press any key to add more or (e) to exit: ");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (userInput != 'e');


            // List - Traversal Section
            SectionSeparator("List - Traversal Section");
            TraverseList(names);


            // List - Reverse Traversal Section
            SectionSeparator("List - Reverse Traversal Section");
            TraverseListReverse(names);
        }

        // SectionSeparator method
        static void SectionSeparator(string sectionName)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"   {sectionName}");
            Console.WriteLine(new string('-', 50));
        }
        
        // CharacterCounter method
        static int CharacterCounter(char characterInput, string word)
        {
            characterInput = char.ToLower(characterInput);
            word = word.ToLower();


            int count = 0;

            foreach (char c in word)
            {
                if (c == characterInput)
                {
                    count++;
                }
            }
            return count;
        }

        // IsPalindrome method
        static bool IsPalindrome(string word)
        {
            word = word.ToLower();
            string reversedWord = "";


            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }


            return word == reversedWord;
        }

        // TraverseList method
        static void TraverseList(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        // TraverseListReverse method
        static void TraverseListReverse(List<string> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }
        }
    }
