using System;

using d2.Library;


namespace d2.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dog = new Dog();
            dog.GoTo("door");
            dog.MakeNoise();
        }
    }
}
