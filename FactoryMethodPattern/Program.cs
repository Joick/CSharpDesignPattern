using System;
using FactoryMethodPattern.Factories;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 生产小米手机
            MobilePhoneFactory factory = new MiPhoneFactory();
            factory.CreatePhoneFactory().ProducePhone();

            // 生产诺基亚
            MobilePhoneFactory factory1 = new NokiaPhoneFactory();
            factory1.CreatePhoneFactory().ProducePhone();
        }
    }
}
