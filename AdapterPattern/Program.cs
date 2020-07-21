using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        { 
            ThreeHolePlug adapter = new PowerAdapter();
            adapter.Charging();
            Console.ReadLine();
        }
    }
}
