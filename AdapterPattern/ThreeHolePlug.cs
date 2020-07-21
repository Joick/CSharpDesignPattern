using System;

namespace AdapterPattern
{
    /// <summary>
    /// 3头插头
    /// </summary>
    public class ThreeHolePlug : IPlug
    {
        /// <summary>
        /// 使用3头插头充电
        /// </summary>
        public virtual void Charging()
        {
            Console.WriteLine("使用3孔插头充电");
        }
    }
}
