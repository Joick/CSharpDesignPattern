using DecoratorPattern.Drink;

namespace DecoratorPattern.Condiment
{
    /// <summary>
    /// 椰果调料
    /// </summary>
    public class CoconutGrain : BaseCondiment
    {
        /// <summary>
        /// 往哪个饮料里加椰果
        /// </summary>
        /// <param name="drink"></param>
        public CoconutGrain(BaseDrink drink)
            : base(drink) { }

        /// <summary>
        /// 添加椰果价格
        /// </summary>
        /// <returns></returns>
        public override decimal GetPrice()
        {
            return 2m + Drink.GetPrice();
        }

        /// <summary>
        /// 获取名称
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return $"Coconut+{Drink.GetName()}";
        }
    }
}
