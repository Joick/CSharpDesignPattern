using System;

namespace AdapterPattern
{
    /// <summary>
    /// 2头插头
    /// </summary>
    public class TwoHolePlug : IPlug
    {
        /// <summary>
        /// 使用2头插头充电
        /// </summary>
        public void Charging()
        {
            Console.WriteLine("使用2孔插头充电");
        }
    }
}
