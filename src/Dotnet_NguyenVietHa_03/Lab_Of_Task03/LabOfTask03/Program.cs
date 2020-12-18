using LapOfTask01;
using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LabOfTask03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello master");
            Console.WriteLine("Press 1: If you want create new list student");
            Console.WriteLine("Press 2: If you want get list student from File");
            Console.Write("Your choose: ");
            
            var students = new List<Student>();
            var command = Console.ReadLine();

            Console.WriteLine("------------------------------");
            //Choose 1 if you want to create new students.
            if (command == "1")
            {

                Console.Write("Enter number student creator: ");
                var count = int.Parse(Console.ReadLine());
                Console.WriteLine("++++++++++++++++++++++++++++++");

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Student no {0}", i + 1);
                    var student = new Student();
                    Console.Write("Family Name: ");
                    student.FamilyName = Console.ReadLine();
                    Console.Write("Middle Name: ");
                    student.MiddleName = Console.ReadLine();
                    Console.Write("Your Name: ");
                    student.Name = Console.ReadLine();
                    Console.Write("PhoneNumber: ");
                    student.PhoneNumber = int.Parse(Console.ReadLine());
                    Console.Write("Email: ");
                    student.YourEmail = Console.ReadLine();

                    Console.WriteLine("==============================");

                    students.Add(student);
                }

                string[] lines = new string[students.Count];
                for (int i = 0; i < students.Count; i++)
                {
                    lines[i] = students[i].ToString();
                }

                System.IO.File.WriteAllLines("student.txt", lines);
            }
            //Choose 2 if you want to see list students.
            else if (command == "2")
            {

                var lines = System.IO.File.ReadAllLines(@"student.txt");
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                    Console.WriteLine("------------------------------");
                }
            }
            // 
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();
        }
    }
}
