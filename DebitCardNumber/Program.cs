using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigits = int.Parse(Console.ReadLine());
            int secondDigits = int.Parse(Console.ReadLine());
            int thirdDigits = int.Parse(Console.ReadLine());
            int fourthDigits = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:0000} {1:0000} {2:0000} {3:0000}", firstDigits, secondDigits, thirdDigits, fourthDigits);
        }
    }
}
