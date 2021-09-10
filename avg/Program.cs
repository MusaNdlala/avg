using System;

namespace avg
{
    class Program
    {
        private static double getAvg(double num1, double num2, double num3)
        {
            double avg = (num1+num2+num3)/3;
            return avg;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter 1st number");
            double num1 = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("please enter 2nd number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter 3rd number");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double answer = getAvg(num1,num2,num3);
            Console.WriteLine(answer);
            Console.Read();
        }
    }
}
