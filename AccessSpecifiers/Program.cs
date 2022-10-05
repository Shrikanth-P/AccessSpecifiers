using System;

namespace AccessSpecifiers
{
    /// <summary>
    /// 1. Show the difference between public and internal programmatically.
    /// public : The type or member can be accessed by any other code in same assembly and another assembly that can references it.
    /// internal : The type or member can be accessed by any code in same assembly, But not in other assembly , internal can't access
    /// Through derived class from another assembly To.
    /// </summary>

    //same assembly
    public class AccessSpecifier
    {
        public int num = 10;
        internal int num1 = 20;
        public static void Main(string[] args)
        {
            AccessSpecifier accessSpecifier = new AccessSpecifier();
            Console.WriteLine("Public variable same Assembly: " + accessSpecifier.num);
            Console.WriteLine("internal variable same Assembly: " + accessSpecifier.num1);
            display dis = new display();
            dis.method();
            dis.method1();
        }
    }
    public class display : AccessSpecifier
    {
        public void method()
        {
            Console.WriteLine("Public variable invoked in child class: " + num);
        }
        internal void method1()
        {
            Console.WriteLine("internal variable invoked in child class: " + num1);
        }

    }
}
