using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            int energyPerHundred = int.Parse(Console.ReadLine());
            int sugarPerHundred = int.Parse(Console.ReadLine());

            double energy = volume * energyPerHundred / 100.00;
            double sugar = volume * sugarPerHundred / 100.00;

            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", energy, sugar);
        }
    }
}
