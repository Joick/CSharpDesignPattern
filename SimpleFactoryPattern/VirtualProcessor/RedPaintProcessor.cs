using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.VirtualProcessor
{
    public class RedPaintProcessor : BaseProcessor
    {
        public RedPaintProcessor()
            : base()
        {
            ColorStr = "红色";
        }
    }
}
