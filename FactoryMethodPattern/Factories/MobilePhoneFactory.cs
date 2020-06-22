using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.Factories
{
    /// <summary>
    /// 手机生产工厂
    /// </summary>
    public abstract class MobilePhoneFactory
    {
        /// <summary>
        /// 获取对应手机工厂
        /// </summary>
        /// <returns></returns>
        public abstract MobilePhone CreatePhoneFactory();
    }
}
