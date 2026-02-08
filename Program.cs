namespace Plindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to check if its palindrome: ");
            string word = Console.ReadLine().ToLower().Trim();
            bool isPalindrome = true;
            int length = word.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - 1 - i])
                {
                    isPalindrome = false; 
                    break; 
                }


            }
            if (isPalindrome)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}

