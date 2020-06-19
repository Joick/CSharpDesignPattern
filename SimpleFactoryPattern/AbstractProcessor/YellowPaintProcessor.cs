using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.AbstractProcessor
{
    public class YellowPaintProcessor:PaintBaseProcessor
    {
        public override void DoColoring()
        {
            Console.WriteLine("用黄色油漆上色");
        }
    }
}
