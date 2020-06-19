using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.VirtualProcessor
{
    public static class ProcessorFactory
    {
        public static BaseProcessor CreatePaint(PaintColor color)
        {
            BaseProcessor matcher;

            switch (color)
            {
                case PaintColor.Red:
                    matcher = new RedPaintProcessor();
                    break;
                case PaintColor.Yellow:
                    matcher = new YellowPaintProcessor();
                    break;
                case PaintColor.Blue:
                    matcher = new BluePaintProcessor();
                    break;
                default:
                    matcher = null;
                    break;
            }

            return matcher;
        }
    }
}
