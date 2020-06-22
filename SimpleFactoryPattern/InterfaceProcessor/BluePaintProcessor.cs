using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.InterfaceProcessor
{
    public class BluePaintProcessor : IProcessor
    {
        public void DoColoring()
        {
            Console.WriteLine("用了蓝色的颜料上色");
        }
    }
}
