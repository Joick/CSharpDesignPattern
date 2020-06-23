using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Products
{
    public class ThinkPadMouse : BaseMouse
    {
        public override void CreateMouse()
        {
            Console.WriteLine("制作联想ThinkPad系列鼠标");
        }
    }
}
