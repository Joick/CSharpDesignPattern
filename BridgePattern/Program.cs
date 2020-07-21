using System;
using BridgePattern.BLL;
using BridgePattern.DAL;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new StudentManageService();
            service.dataAccess = new StudentDataAccess();

            service.List();
            service.Add("猪小屁");

            service.List();
            service.Delete("张三");

            service.List();
            service.Update(3,"诸葛");

            service.List();
            service.Get(4);

            Console.ReadLine();
        }
    }
}
