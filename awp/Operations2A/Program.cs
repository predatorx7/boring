using System;

namespace Operations2A
{
    class Quadraticroots
    {
        double a, b, c;

        public void read()
        {
            Console.WriteLine("To find the roots of a quadratic equation of the form a*x*x + b*x + c = 0");
            Console.Write("Enter value for a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter value for b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter value for c: ");
            c = double.Parse(Console.ReadLine());
        }
        public void compute()
        {
            int m;
            double r1, r2, d1;
            d1 = b * b - 4 * a * c;
            if (a == 0)
                m = 1;
            else if (d1 > 0)
                m = 2;
            else if (d1 == 0)
                m = 3;
            else
                m = 4;
            switch (m)
            {
                case 1:
                    Console.WriteLine("Not a Quadratic equation, Linear equation");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Roots are Real and Distinct");
                    r1 = (-b + Math.Sqrt(d1)) / (2 * a);
                    r2 = (-b - Math.Sqrt(d1)) / (2 * a);
                    Console.WriteLine("First root is {0:#.##}", r1);
                    Console.WriteLine("Second root is {0:#.##}", r2);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Roots are Real and Equal");
                    r1 = r2 = (-b) / (2 * a);
                    Console.WriteLine("First root is {0:#.##}", r1);
                    Console.WriteLine("Second root is {0:#.##}", r2);
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("\n Roots are Imaginary");
                    r1 = (-b) / (2 * a);
                    r2 = Math.Sqrt(-d1) / (2 * a);
                    Console.WriteLine("\n First root is {0:#.##} + i {1:#.##}", r1, r2);
                    Console.WriteLine("\n Second root is {0:#.##} - i {1:#.##}", r1, r2);
                    Console.ReadLine();
                    break;
            }
        }

    }
        class Program
    {
        static void findFactorial()
        {
            Console.WriteLine("Find factorial");
            int i, number, fact;
            Console.Write("Enter the Number: ");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + fact);
            Console.ReadKey();
        }
        static void moneyConversion()
        {
            Console.WriteLine("\nMoney conversion: ");
            int choice;
            Console.Write("Choices:\n1 - Dollar to Rupee\n2 - Euro to Rupee\n3 - Malaysian Ringgit to Rupee\nEnter your Choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Double dollar, rupee, val;
                    Console.Write("Enter the Dollar Amount: ");
                    dollar = Double.Parse(Console.ReadLine());
                    Console.Write("Enter the Dollar Value: ");
                    val = double.Parse(Console.ReadLine());
                    rupee = dollar * val;
                    Console.WriteLine("{0} Dollar equals to {1} Rupees", dollar, rupee);
                    break;
                case 2:
                    Double Euro, rupe, valu;
                    Console.Write("Enter the Euro Amount: ");
                    Euro = Double.Parse(Console.ReadLine());
                    Console.Write("Enter the Euro Value: ");
                    valu = double.Parse(Console.ReadLine());
                    rupe = Euro * valu;
                    Console.WriteLine("{0} Euro equals to {1} Rupees ", Euro, rupe);
                    break;
                case 3:
                    Double ringit, rup, value;
                    Console.Write("Enter the Ringgit Amount: ");
                    ringit = Double.Parse(Console.ReadLine());
                    Console.Write("Enter the Ringgit Value: ");
                    value = double.Parse(Console.ReadLine());
                    rup = ringit * value;
                    Console.WriteLine("{0}Malaysian Ringgit equals to {1} Rupees", ringit, rup);
                    break;
            }
        }

        static void quadraticRoots()
        {
            Console.WriteLine("\nQuadratic roots");
            Quadraticroots qr = new Quadraticroots();
            qr.read();
            qr.compute();
        }

        static void temperatureConversion()
        {
            Console.WriteLine("\nTemperatue conversion");
            int celsius, faren;
            Console.Write("Enter the Temperature in Celsius(°C): ");
            celsius = int.Parse(Console.ReadLine());
            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is(°F): " + faren);
        }

        static void Main(string[] args)
        {
            findFactorial();
            moneyConversion();
            quadraticRoots();
            temperatureConversion();
            Console.ReadKey();
        }
    }
}
