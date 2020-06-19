using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.AbstractProcessor
{
    public class BluePaintProcessor : PaintBaseProcessor
    {
        public override void DoColoring()
        {
            Console.WriteLine("用蓝色油漆上色");
        }
    }
}
