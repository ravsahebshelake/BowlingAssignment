using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // A a = new A();
            B b = new B();
            A a1 = new B();
            B b1 = new A() as B;
            Console.Read();
        }
    }

    class A
    {
        public A()
        {
            Console.WriteLine("From Abstract Class");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("From Derived Class");
        }
    }
}
