using System;

namespace FactoryMethodPattern.Products
{
    /// <summary>
    /// 诺基亚手机
    /// </summary>
    public class NokiaPhone : MobilePhone
    {
        /// <summary>
        /// 生产手机
        /// </summary>
        public override void ProducePhone()
        {
            Console.WriteLine("生产了诺基亚手机");
        }
    }
}
