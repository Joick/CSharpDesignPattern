using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.Factories
{
    /// <summary>
    /// 诺基亚手机工厂
    /// </summary>
    public class NokiaPhoneFactory : MobilePhoneFactory
    {
        /// <summary>
        /// 创建手机
        /// </summary>
        /// <returns></returns>
        public override MobilePhone CreatePhoneFactory()
        {
            return new NokiaPhone();
        }
    }
}
