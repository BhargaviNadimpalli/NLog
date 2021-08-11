using System;

namespace NlogSession
{
    class Program
    {
        private static string result;

        static void Main(string[] args)
        {
            Console.WriteLine("Addition on numbers \n Enter values : " + result);
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            var add = new AddNumbers();
            Console.WriteLine("Result is " + " " + add.Sum(firstNumber, secondNumber));

        }
    }
}
