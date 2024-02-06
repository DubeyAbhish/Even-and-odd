using System;
namespace Ram
{

    class laxman
    {
        public static void Main()
        {
            Console.WriteLine("Enter your Number :");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number % 2 == 0)
            {
                Console.Write("This is Even Number :");
            }
            else
            {
                Console.Write("This is Odd Number");
            }
        }

    }
}
