using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.AbstractProcessor
{
    public class RedPaintProcessor:PaintBaseProcessor
    {
        public override void DoColoring()
        {
            Console.WriteLine("用红色油漆上色");
        }
    }
}
