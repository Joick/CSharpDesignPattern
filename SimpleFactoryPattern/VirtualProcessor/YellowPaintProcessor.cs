using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.VirtualProcessor
{
    public class YellowPaintProcessor : BaseProcessor
    {
        public YellowPaintProcessor()
            : base()
        {
            ColorStr = "黄色";
        }
    }
}
