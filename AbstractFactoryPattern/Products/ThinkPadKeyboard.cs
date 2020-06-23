using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Products
{
    public class ThinkPadKeyboard : BaseKeyboard
    {
        public override void CreateKeyboard()
        {
            Console.WriteLine("制作ThinkPad巧克力键盘");
        }
    }
}
