using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student()
        {
        }

        public Student(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public void ShowThongTin()
        {
            Console.WriteLine($"{Id} - {Name} - {Age}");
        }
        public override String ToString()
        {
            return $"{Id} -{Name} - {Age}";
        }
    }
}