using System;

namespace getter_and_setters
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.GetName());
            myClass.SetName("Jane Doe");
            Console.WriteLine(myClass.GetName());
        }
    }

    internal class MyClass
    {
        private string name = "John Doe";

        internal void SetName(string newName)
        {
            name = newName;
        }
        internal string GetName()
        {
            return name;
        }
    }
}
