using DecoratorPattern.Drink;

namespace DecoratorPattern.Condiment
{
    /// <summary>
    /// 调味料基类
    /// </summary>
    public abstract class BaseCondiment : BaseDrink
    {
        /// <summary>
        /// 实例饮料对象
        /// </summary>
        protected BaseDrink Drink;

        protected BaseCondiment(BaseDrink drink)
        {
            Drink = drink;
        }

        /// <summary>
        /// 名称
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return Drink.GetName();
        }
    }
}
