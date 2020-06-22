using System;

namespace FactoryMethodPattern.Products
{
    /// <summary>
    /// 小米手机
    /// </summary>
    public class MiPhone : MobilePhone
    {
        /// <summary>
        /// 生产手机
        /// </summary>
        public override void ProducePhone()
        {
            Console.WriteLine("生产小米手机");
        }
    }
}
