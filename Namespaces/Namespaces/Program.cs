using System;

namespace Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeyJij.SayHi text1 = new HeyJij.SayHi();
            text1.sayHi();
        }
    }
}

namespace HeyJij
{
    class SayHi
    {
        public void sayHi()
        {
            Console.WriteLine("Hey, ik ben kayran");
        }
    }
}
