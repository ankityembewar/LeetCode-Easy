using System;

namespace Two_Sum
{
    class Program
    {
        #region TwoSum

        /// <summary>
        /// This method return sum of two numbers to acheive target
        /// </summary>
        /// <param name="nums">integer array</param>
        /// <param name="target">integer</param>
        public static void TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        Console.WriteLine($"From array we can achieve target by adding {nums[i]} and {nums[j]}");

                    }
                }
            }
            Console.ReadLine();
            
        }
        #endregion

        #region Program Execution
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array : ");
            int size_of_array = int.Parse(Console.ReadLine());
            int[] nums = new int[size_of_array];
            for(int i=0;i<size_of_array;i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Target : ");
            int target = int.Parse(Console.ReadLine());

            TwoSum(nums, target);
            
        }
        #endregion
    }
}
