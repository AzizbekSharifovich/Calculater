using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ismingizni kiriting:");
            string ism = Console.ReadLine();

            Console.WriteLine("Yoshingizni kiriting:");
            int yosh = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yashash joyingizni kiriting:");
            string joy = Console.ReadLine();

            Console.WriteLine($"Sizning ismingiz: {ism}");
            Console.WriteLine($"Sizning yoshingiz: {yosh}");
            Console.WriteLine($"Siz {joy} da yashaysiz.");
        }
    }
}

