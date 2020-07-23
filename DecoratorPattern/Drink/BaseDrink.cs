namespace DecoratorPattern.Drink
{
    /// <summary>
    /// 饮料基类
    /// </summary>
    public abstract class BaseDrink
    {
        /// <summary>
        /// 获取饮料名字
        /// </summary>
        /// <returns></returns>
        public abstract string GetName();

        /// <summary>
        /// 获取饮料价格
        /// </summary>
        /// <returns></returns>
        public abstract decimal GetPrice();
    }
}
