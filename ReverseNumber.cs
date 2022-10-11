using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class ReverseNumber
    {
        public static void FindReverseNumber()
        {
            int num, reverse = 0, rem;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;

            }

            Console.WriteLine("Reversed Number" + reverse);
        }
    }
}
