using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo danh sách học sinh
            List<Student> studentList = new List<Student>
            {
                new Student(001, "An Giang", 13),
                new Student(002, "Nguyen Thi B", 14),
                new Student(003, "Tran Van C", 11),
                new Student(004, "Tran Thi D", 17),
                new Student(005, "Hoang Van E", 15)
            };

            // In ra danh sách học sinh
            Console.WriteLine("Danh sách học sinh:");
            studentList.ForEach(student => Console.WriteLine(student));

            // Lọc học sinh trong độ tuổi từ 15 đến 18
            Console.WriteLine("Danh sách học sinh từ 15 đến 18 tuổi:");
            var ageRange = studentList.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var student in ageRange)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine();

            // Lọc học sinh có tên bắt đầu bằng chữ A
            Console.WriteLine("Danh sách học sinh có tên bắt đầu bằng chữ A:");
            var studentsWithA = studentList.Where(s => s.Name.StartsWith("A"));
            foreach (var student in studentsWithA)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // Tính tổng tuổi của học sinh
            int totalAge = studentList.Sum(s => s.Age);
            Console.WriteLine($"Tổng tuổi học sinh: {totalAge}");
            Console.WriteLine();

            // Lấy học sinh có độ tuổi lớn nhất
            var oldestStudent = studentList.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine($"Học sinh có độ tuổi lớn nhất: ID: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

            // In danh sách học sinh theo độ tuổi tăng dần
            Console.WriteLine("Danh sách học sinh theo độ tuổi tăng dần:");
            var sortedByAge = studentList.OrderBy(s => s.Age);
            foreach (var student in sortedByAge)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}