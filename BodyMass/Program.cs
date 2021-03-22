using System;

namespace BodyMass
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter height
            Console.Write("enter your height (meters): ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            //enter weight
            Console.Write("enter your weight (kilograms): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            //BMI calculation
            double bmi = weight/ Math.Pow(height, 2);

            //booleon
            if (bmi <=25 && bmi>=18.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("you are average. your BMI is "+bmi);
            }
            else if (bmi < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("you are underwight. your BMI is "+bmi);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("you are overweight. your BMI is "+bmi);
            }

            Console.Write("press any key to close program");
            Console.ReadLine();

        }
    }
}
