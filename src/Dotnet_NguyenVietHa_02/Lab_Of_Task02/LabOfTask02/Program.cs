using LapOfTask01;
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
            //#1 That is list of student.
            var students = new List<Student>();
            Console.Write("Enter NUMBER of student you want: ");
            var count = int.Parse(Console.ReadLine());

            Console.WriteLine("==============================");

            //#2 I will write info about student here.
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Please enter student no {0}", i + 1);
                var student = new Student();
                Console.WriteLine("New : ");
                //1. Write family name.
                Console.Write("Family name: ");
                student.FamilyName = Console.ReadLine();
                //2. Write middle name.
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
                    Console.WriteLine("This is not number!!!! I will leave your phone number blank");
                    student.PhoneNumber = 0;
                }

                Console.WriteLine("==============================");

                //6. We add student here.
                students.Add(student);
            }
            //#3 We will search student here.
            foreach(var student in students)
            {
                Console.WriteLine($"Student : {student.FamilyName} {student.MiddleName} {student.Name}\n" +
                    $"Number phone: {student.PhoneNumber} \nEmail: {student.YourEmail}");
                Console.WriteLine("------------------------------");
            }

            Console.ReadKey();
        }
    }
}
