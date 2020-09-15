using System;

namespace Operations2A
{
    class Program
    {
        static void GenerateFibonacci()
        {
            Console.WriteLine("FIBONACCI SERIES");
            int num1 = 0, num2 = 1, num3, limit, counter;
            Console.Write("Upto how many number you want fibonacci series: ");
            limit = int.Parse(Console.ReadLine());
            counter = 3;
            Console.Write(num1 + " " + num2);
            while (counter <= limit)
            {
                num3 = num1 + num2;
                if (counter >= limit)
                    break;
                Console.Write(" " + num3);
                num1 = num2;
                num2 = num3;
                counter++;
            }
        }
        static void TestPrime()
        {
            Console.WriteLine("\n\nTest for Prime numbers");
            int num, counter;
            Console.Write("Enter number:");
            num = int.Parse(Console.ReadLine());
            for (counter = 2; counter <= num / 2; counter++)
            {
                if ((num % counter) == 0)
                    break;
            }
            if (num == 1)
                Console.WriteLine(num + " is neither prime nor composite");
            else if (counter < (num / 2))
                Console.WriteLine(num + " is not prime number");
            else
                Console.WriteLine(num + " is prime number");
        }
        static void TestVowels()
        {
            Console.WriteLine("\nTest Vowels");
            char ch;
            Console.Write("Enter a character: ");
            ch = (char) Console.ReadLine()[0];
            switch (ch)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine(ch + " is vowel");
                    break;
                default:
                    Console.Write(ch + " is not a vowel");
                    break;
            }
        }

        static void ForeachArrays()
        {
            Console.WriteLine("\nForeach Arrays");
            string[] str = { "One", "Two", "Three" };
            foreach (String s in str)
            {
                Console.WriteLine(s);
            }
        }

        static void ReverseNSumNumber()
        {
            Console.WriteLine("\nReverse Number");
            int num, actualnumber, revnum = 0, digit, sumDigits = 0;
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            actualnumber = num;
            while (num > 0)
            {
                digit = num % 10;
                revnum = revnum * 10 + digit;
                sumDigits = sumDigits + digit;
                num = num / 10;
            }
            Console.WriteLine("Reverse of " + actualnumber + "=" + revnum);
            Console.WriteLine("Sum of its digits: " + sumDigits);

        }

        static void Main(string[] args)
        {
            GenerateFibonacci();
            TestPrime();
            TestVowels();
            ForeachArrays();
            ReverseNSumNumber();
            Console.ReadKey();
        }
    }
}
