using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Products
{
    public class MacMouse:BaseMouse
    {
        public override void CreateMouse()
        {
            Console.WriteLine("制作苹果鼠标");
        }
    }
}
