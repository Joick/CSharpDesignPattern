using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.AbstractProcessor
{
    public static class ProcessorFactory
    {
        public static PaintBaseProcessor CreatePaint(PaintColor color)
        {
            PaintBaseProcessor matcher;

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
