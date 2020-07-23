namespace DecoratorPattern.Drink
{
    /// <summary>
    /// 果汁饮料
    /// </summary>
    public class JuiceDrink : BaseDrink
    {
        /// <summary>
        /// 获取果汁饮料名称
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return "果汁";
        }

        /// <summary>
        /// 获取果汁饮料价格
        /// </summary>
        /// <returns></returns>
        public override decimal GetPrice()
        {
            return 5m;
        }
    }
}
