using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = SingletonSample.GetInstance();
            instance?.Print();
            Console.WriteLine("exit");
        }
    }
}
