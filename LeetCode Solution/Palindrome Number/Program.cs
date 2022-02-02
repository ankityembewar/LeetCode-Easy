using System;

namespace Palindrome_Number
{
    class Program
    {
        #region IsPalindrome

        /// <summary>
        /// Checking entered number is palidrome or not
        /// </summary>
        /// <param name="inputNumber">input number</param>
        public static void IsPalindrome(int inputNumber)
        {
            string givenNumber = inputNumber.ToString();
            string checker = "";
            for(int i= givenNumber.Length-1;i>=0;i--)
            {
                checker += givenNumber[i];
            }
            if(checker== givenNumber)
            {
                Console.WriteLine("Entered number is palindrome");
            }
            else
            {
                Console.WriteLine("Entered number is not palindrome");
            }
        }
        #endregion

        #region Program Execution
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int inputNumber = int.Parse(Console.ReadLine());
            IsPalindrome(inputNumber);
            Console.ReadLine();
        }
        #endregion
    }
}
