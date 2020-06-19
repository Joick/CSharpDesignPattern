using System;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 传入颜色为判断参数,获取对应颜色的油漆
            var paint = AbstractProcessor.ProcessorFactory.CreatePaint(PaintColor.Red);

            // 用油漆上色
            paint.DoColoring();


            var paint1 = VirtualProcessor.ProcessorFactory.CreatePaint(PaintColor.Blue);
            paint1.DoColoring();
        }
    }
}
