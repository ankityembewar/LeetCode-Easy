using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int output = 0;
            string input = Console.ReadLine();
            for(int i=0;i<input.Length;i++)
            {
                if(input[i]=='I')
                {
                    output += 1;
                }
                else if(input[i]=='V')
                {
                    output += 5;
                }
                else if (input[i] == 'X')
                {
                    output += 10;
                }
                else if (input[i] == 'L')
                {
                    output += 50;
                }
                else if (input[i] == 'C')
                {
                    output += 100;
                }
                else if (input[i] == 'D')
                {
                    output += 500;
                }
                else if (input[i] == 'M')
                {
                    output += 100;
                }


            }
            if (input.Contains("CD") || input.Contains("CM"))
                output -= 200;
            if (input.Contains("XL") || input.Contains("XC"))
                output -= 20;
            if (input.Contains("IV") || input.Contains("IX"))
                output -= 2;
        }
    }
}
