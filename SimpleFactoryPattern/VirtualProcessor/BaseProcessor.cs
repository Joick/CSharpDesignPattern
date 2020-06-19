using System;
using System.Collections.Generic;
using System.Text;
using SimpleFactoryPattern.AbstractProcessor;

namespace SimpleFactoryPattern.VirtualProcessor
{
    public class BaseProcessor
    {
        protected string ColorStr;
        public BaseProcessor()
        {
        }

        public virtual void DoColoring()
        {
            Console.WriteLine($"用{ColorStr}油漆上色");
        }
    }
}
