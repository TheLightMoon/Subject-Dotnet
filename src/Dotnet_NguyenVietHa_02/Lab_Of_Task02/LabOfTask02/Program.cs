using LabOfTask01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOfTask02
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1 That is a list of students.
            var students = new List<Student>();
            Console.Write("Enter NUMBER of student you want: ");
            var count = int.Parse(Console.ReadLine());

            Console.WriteLine("==============================");

            //#2 I will write info about students here.
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Please enter student no {0}", i + 1);
                var student = new Student();
                Console.WriteLine("New : ");
                //1. Write a family name.
                Console.Write("Family name: ");
                student.FamilyName = Console.ReadLine();
                //2. Write a middle name.
                Console.Write("Middle name: ");
                student.MiddleName = Console.ReadLine();
                //3. Write name.
                Console.Write("Your name: ");
                student.Name = Console.ReadLine();
                //4. Write email here.
                Console.Write("Your Email: ");
                student.YourEmail = Console.ReadLine();
                //5. Write number phone.
                Console.Write("Your Number: ");
                if(int.TryParse(Console.ReadLine(), out int number1))
                {
                    student.PhoneNumber = number1;
                }
                else
                {
                    Console.WriteLine("This is not numbers!!!! I will leave your phone number blank");
                    student.PhoneNumber = 0;
                }

                Console.WriteLine("==============================");

                //6. We add students here.
                students.Add(student);
            }
            //#3 We will search for students here.
            foreach(var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine("------------------------------");
            }

            Console.ReadKey();
        }
    }
}
