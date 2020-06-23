using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Products
{
    public class MacKeyboard:BaseKeyboard
    {
        public override void CreateKeyboard()
        {
            Console.WriteLine("制作苹果蓝牙键盘");
        }
    }
}
