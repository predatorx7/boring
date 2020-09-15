using System;

namespace DelegateAndEvent
{
    public delegate void TrafficDel();
    class TrafficSignal
    {
        public static void Yellow()
        {
            Console.WriteLine("Yellow light signals to get ready");
        }
        public static void Green()
        {
            Console.WriteLine("Green light signals to go");
        }
        public static void Red()
        {
            Console.WriteLine("Red light signals to stop");
        }
        TrafficDel[] td = new TrafficDel[3];
        public void IdentifySignal()
        {
            td[0] = new TrafficDel(Yellow);
            td[1] = new TrafficDel(Green);
            td[2] = new TrafficDel(Red);
        }
        public void display()
        {
            td[0]();
            td[1]();
            td[2]();
        }
    }

    class NotEvenException : Exception
    {
        public NotEvenException(string msg)
        : base(msg)
        {
        }
    }


    class Program
    {
        static void delegateExample()
        {
            Console.WriteLine("\nDelegate & Events example");
            TrafficSignal ts = new TrafficSignal();
            ts.IdentifySignal();
            ts.display();
        }

        static void handlingExceptions()
        {
            Console.WriteLine("\nException handling");
            int num;
            try
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                if ((num % 2) != 0) throw new NotEvenException("Not an even number ");
                else
                    Console.WriteLine("Its even number ");
            }
            catch (NotEvenException e) { Console.WriteLine(e.Message); }
        }

        static void Main(string[] args)
        {
            delegateExample();
            handlingExceptions();
            Console.ReadKey();
        }
    }
}
