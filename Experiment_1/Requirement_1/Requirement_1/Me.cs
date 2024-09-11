using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_1
{
    internal class Me(string student_number, string name, string specialized)
    {
        public string Student_number { get; set; } = student_number;
        public string Name { get; set; } = name;
        public string Specialized { get; set; } = specialized;

        public void OutputInfo()
        {
            Console.WriteLine($"我的学号：{Student_number}");
            Console.WriteLine($"我的姓名：{Name}");
            Console.WriteLine($"我的专业：{Specialized}");
        }
    }
}
