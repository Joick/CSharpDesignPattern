using System;
using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var macFactory = new MacPcFactory();
            macFactory.CreateMouseFactory().CreateMouse();
            macFactory.CreateKeyboardFactory().CreateKeyboard();

            var thinkpadFactory = new ThinkPadPcFactory();
            thinkpadFactory.CreateMouseFactory().CreateMouse();
            thinkpadFactory.CreateKeyboardFactory().CreateKeyboard();
        }
    }
}
