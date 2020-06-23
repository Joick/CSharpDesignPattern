using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = "小明";
            var rechargeActivity = new RechargeActivity(user);
            rechargeActivity.JoinActivity();

            Console.WriteLine("\r\n------------------华丽丽的分割线-------------------\r\n");

            var consumeActivity = new ConsumeActivity(user);
            consumeActivity.JoinActivity();
        }
    }
}
