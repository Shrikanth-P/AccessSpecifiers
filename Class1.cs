using System;
using AccessSpecifiers;

namespace OtherAssembly
{
    class otherAssembly
    {
        public void Method1()
        {
            AccessSpecifier accessSpecifiers = new AccessSpecifier();
            Console.WriteLine("another Assembly accessing the public member " + accessSpecifiers.num);
            Console.WriteLine("another Assembly accessing the public member " + accessSpecifiers.num1);
            internal int a = 100;
            public int b = 200;
        }
    }
}