using System;

namespace Method_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first digit");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("you have entered {0}, please enter the second digit", num1);

            int num2 = Int32.Parse(Console.ReadLine());
            Console.Write("The sum of {0} and {1} is {2}", num1, num2, Add(num1, num2));
            Console.Read();
        }
        public static int Add(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
