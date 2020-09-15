using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrate1
{
    class Overloading
    {
        public void swap(ref int n, ref int m)
        {
            int t;
            t = n;
            n = m;
            m = t;
        }
        public void swap(ref float f1, ref float f2)
        {
            float f;
            f = f1;
            f1 = f2;
            f2 = f;
        }
    }

    class Furniture
    {
        string material;
        float price;
        public void getdata()
        {
            Console.Write("Enter material : ");
            material = Console.ReadLine();
            Console.Write("Enter price : ");
            price = float.Parse(Console.ReadLine());
        }
        public void showdata()
        {
            Console.WriteLine("Material : " + material);
            Console.WriteLine("Price : " + price);
        }
    }

    class Table : Furniture
    {
        int height, surface_area;
        public void getdata()
        {
            base.getdata();
            Console.Write("Enter height: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Enter surface area: ");
            surface_area = int.Parse(Console.ReadLine());
        }
        public void showdata()
        {
            base.showdata();
            Console.WriteLine("Height : " + height);
            Console.WriteLine("Surface Area : " + surface_area);
        }
    }

    class A
    {
        public void About()
        {
            Console.WriteLine("About method from class A");
        }
    }

    class B : A
    {
    }

    class C : B
    {

    }

    interface D
    {
        void say();
    }

    class E : A, D
    {
        public void say()
        {
            Console.WriteLine("Inherited 'say' from an interface");
        }
    }

    class Salary
    {
        int basic, ta, da, hra;
        public Salary()
        {
            da = 9000;
            hra = 6000;
        }
        public void getdata()
        {
            Console.Write("Enter basic salary : ");
            basic = int.Parse(Console.ReadLine());
            Console.Write("Enter travelling allowance : ");
            ta = int.Parse(Console.ReadLine());
        }
        public void showdata()
        {
            Console.WriteLine("Basic salary : " + basic);
            Console.WriteLine("Dearness allowence : " + da);
            Console.WriteLine("Housing rent allowence : " + hra);
            Console.WriteLine("Travelling allowence : " + ta);
            Console.WriteLine("Gross Salary : " + (basic + da + hra + ta));
        }
    }


    class Program
    {
        static void overloading()
        {
            Console.WriteLine("\nOverloading");
            Overloading objOverloading = new Overloading();
            int n = 10, m = 20;
            objOverloading.swap(ref n, ref m);
            Console.WriteLine("N=" + n + "\tM=" + m);
            float f1 = 10.5f, f2 = 20.6f;
            objOverloading.swap(ref f1, ref f2);
            Console.WriteLine("F1=" + f1 + "\tF2=" + f2);
        }

        static void singleInheritance()
        {
            B obj = new B();
            obj.About();
        }

       static void multipleInheritance()
        {
            E obj = new E();
            obj.About();
            obj.say();
        }

       static void multilevelInheritance()
        {
            C obj = new C();
            obj.About();
        }

        static void hierarchicalInheritance()
        {
            B obj1 = new B();
            E obj2 = new E();
            obj1.About();
            obj2.About();
        }

       static void inheritance()
        {
            Console.WriteLine("\nInheritance");
            singleInheritance();
            multipleInheritance();
            multilevelInheritance();
            hierarchicalInheritance();
        }

        static void constructorOverloading()
        {
            Console.WriteLine("\nConstructor overloading");
            Salary s = new Salary();
            s.getdata();
            s.showdata();
        }


        static void interfaceDemo()
        {
            Console.WriteLine("\nInterface");
            // uses interface
            hierarchicalInheritance();
        }

        static void Main(string[] args)
        {
            overloading();
            inheritance();
            constructorOverloading();
            interfaceDemo();
            Console.ReadKey();
        }
    }
}
