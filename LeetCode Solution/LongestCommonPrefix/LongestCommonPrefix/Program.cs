using System;

namespace LongestCommonPrefix
{
    class Program
    {
        #region LongestCommonPrefix

        /// <summary>
        /// This method returns longest common prefix char of word
        /// </summary>
        /// <param name="strs">words</param>
        /// <returns>Longest common prefix of words</returns>
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "Input is not entered ..!";

            for (int outerIndex = 0; outerIndex < strs[0].Length; outerIndex++)
            {
                char current = strs[0][outerIndex];

                for (int innerIndex = 1; innerIndex < strs.Length; innerIndex++)
                {
                    if (strs[innerIndex].Length < outerIndex + 1 || current != strs[innerIndex][outerIndex])
                    {
                        return "Longest common prefix : "+strs[0].Substring(0, outerIndex);
                    }       
                }
            }

            return "No common prefix in words ..!";
        }
        #endregion

        #region Program Execution
        static void Main()
        {
            Console.Write("Enter total number of words: ");
            int num_of_words = int.Parse(Console.ReadLine());
            string[] strs = new String[num_of_words];
            for(int i=0;i<num_of_words;i++)
            {
                Console.Write(i+1+". ");
                strs[i] = Console.ReadLine();
                Console.WriteLine();
            }
            
            string output = LongestCommonPrefix(strs);

            Console.WriteLine(output);
            Console.ReadLine();
           
        }
        #endregion
    }
}
