using DecoratorPattern.Drink;

namespace DecoratorPattern.Condiment
{
    /// <summary>
    /// 布丁调料
    /// </summary>
    public class Pudding : BaseCondiment
    {
        /// <summary>
        /// 往饮料里加布丁
        /// </summary>
        /// <param name="drink"></param>
        public Pudding(BaseDrink drink)
            : base(drink) { }

        /// <summary>
        /// 获取加布丁后的价格
        /// </summary>
        /// <returns></returns>
        public override decimal GetPrice()
        {
            return 4m + Drink.GetPrice();
        }

        /// <summary>
        /// 获取加布丁后的名字
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return $"Pudding+{Drink.GetName()}";
        }
    }
}
