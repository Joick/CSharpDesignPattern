using System;

namespace SingletonPattern
{
    /// <summary>
    /// 单例模式类
    /// </summary>
    public class SingletonSample
    {
        /// <summary>
        /// 静态变量存储类的实例
        /// </summary>
        private static SingletonSample _instance;

        ///// <summary>
        ///// 如果出现多线程情况,考虑使用volatile关键字
        ///// </summary>
        //private static volatile SingletonSample _instance;

        /// <summary>
        /// 锁
        /// </summary>
        private static readonly object InstanceLocker = new object();

        /// <summary>
        /// 私有构造函数, 使得类无法在外部被实例化
        /// </summary>
        private SingletonSample() { }

        /// <summary>
        /// 使用方法获取单例实例
        /// </summary>
        /// <returns></returns>
        public static SingletonSample GetInstance()
        {
            if (_instance != null)
                return _instance;

            lock (InstanceLocker)
            {
                if (_instance == null)
                {
                    _instance = new SingletonSample();
                }
            }

            return _instance;
        }

        /// <summary>
        /// 调用方法
        /// </summary>
        public void Print()
        {
            Console.WriteLine("print");
        }
    }
}
