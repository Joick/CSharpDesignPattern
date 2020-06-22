using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.InterfaceProcessor
{
    public class RedPaintProcessor:IProcessor
    {
        public void DoColoring()
        {
            Console.WriteLine("选择使用红色的颜料上色");
        }
    }
}
