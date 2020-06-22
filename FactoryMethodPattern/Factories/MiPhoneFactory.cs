using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.Factories
{
    /// <summary>
    /// 小米手机工厂
    /// </summary>
    public class MiPhoneFactory : MobilePhoneFactory
    {
        /// <summary>
        /// 生产手机
        /// </summary>
        /// <returns></returns>
        public override MobilePhone CreatePhoneFactory()
        {
            return new MiPhone();
        }
    }
}
