using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.DAL
{
    public class StudentDataAccess : BaseDataAccess
    {
        public static List<string> Student;

        public StudentDataAccess()
        {
            Student = new List<string>()
            {
                "张三","李四","王五","赵大","钱二"
            };
        }

        public override void Add(string data)
        {
            Console.WriteLine($"添加学生：{data}");
            Student.Add(data);
        }

        public override void Update(int index, string data)
        {
            Console.WriteLine($"更新学生：{data}");
            Student[index] = data;
        }

        public override void Delete(string data)
        {
            Console.WriteLine($"删除学生：{data}");
            Student.Remove(data);
        }

        public override string Get(int index)
        {
            Console.WriteLine($"查询学生：{Student[index]}");
            return Student[index];
        }

        public override void List()
        {
            Console.WriteLine($"获取学生列表：{string.Join(",", Student)}");
        }
    }
}
