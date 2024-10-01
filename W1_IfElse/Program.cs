using System;

namespace W1_IfElse
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Lütfen bir sayı giriniz: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input > 10)
            {
                Console.WriteLine("Girilen sayı 10'dan buyuktur.");
            } else if (input < 10) {
                Console.WriteLine("Girilen sayı 10'dan kucuktur.");
            } else {
                Console.WriteLine("Girilen sayı 10'a esittir.");
            }

            if (input % 2 == 0)
            {
                Console.WriteLine("Girilen sayı cifttir.");
            } else {
                Console.WriteLine("Girilen sayı tektir.");
            }
        }
    }
}