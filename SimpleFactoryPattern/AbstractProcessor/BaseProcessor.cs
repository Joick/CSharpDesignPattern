using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.AbstractProcessor
{
    /// <summary>
    /// 油漆基类
    /// </summary>
    public abstract class PaintBaseProcessor
    {
        /// <summary>
        /// 上色
        /// </summary>
        public abstract void DoColoring();
    }
}
