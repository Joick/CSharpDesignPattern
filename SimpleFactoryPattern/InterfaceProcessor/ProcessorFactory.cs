using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.InterfaceProcessor
{
    public static class ProcessorFactory
    {
        public static IProcessor CreatePaint(PaintColor color)
        {
            IProcessor matcher;
            switch (color)
            {
                case PaintColor.Blue:
                    matcher=new BluePaintProcessor();
                    break;
                case PaintColor.Red:
                    matcher = new RedPaintProcessor();
                    break;
                default:
                    matcher = null;
                    break;
            }

            return matcher;
        }
    }
}
