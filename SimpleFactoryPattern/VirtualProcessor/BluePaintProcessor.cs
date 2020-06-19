using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.VirtualProcessor
{
    public class BluePaintProcessor : BaseProcessor
    {
        public BluePaintProcessor() 
            : base()
        {
            ColorStr = "蓝色";
        }
    }
}
