using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, gender;

            GetData(out name, out gender);

            int age = GetAge();

            Console.WriteLine("Name: {0}, Gender: {1}, Age: {2}", name, gender, age);

            Console.ReadLine();
        }

        static void GetData(out string name, out string gender)
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your gender: ");
            gender = Console.ReadLine();
        }

        static int GetAge()
        {
            bool valid = false;
            int number = 0;

            while(!valid)
            {
                Console.Write("Enter your age: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("That is not an integer!");
                }
            }

            return number;
        }
    }
}
