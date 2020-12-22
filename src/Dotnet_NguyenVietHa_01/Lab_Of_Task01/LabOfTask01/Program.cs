using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LabOfTask01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            //Enter the group name.
            Console.Write("Write your group: ");
            student.NameGroup = Console.ReadLine();
            Console.Write("That is your group? " + "===> ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(student.NameGroup);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" <===\n");

            //Enter the full name. 
            //1# Family name:
            Console.Write("Write family name: ");
            student.FamilyName = Console.ReadLine();
            Console.Write("That is your family name? " + "===> ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(student.FamilyName);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" <===\n");
            //2# Middle name:
            Console.Write("Write middle name: ");
            student.MiddleName = Console.ReadLine();
            Console.Write("That is your MiddleName? " + "===> ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(student.MiddleName);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" <===\n");
            //3# Your name:
            Console.Write("Write your name: ");
            student.Name = Console.ReadLine();
            Console.Write("That is your name? " + "===> ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(student.Name);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" <===\n");
            //Show full name.
            Console.Write("This is full your name? " + "===> ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(student.FamilyName + " " + student.MiddleName + " " + student.Name);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" <===\n");

            //Enter your number phone.
            Console.Write("Write yor number phone: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                student.PhoneNumber = number;
                Console.Write("This your number? " + "===> ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(number);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" <===\n");
            }
            else
            {
                Console.WriteLine("Sorry it's not number !\n");
            }

            //Enter the email
            Console.Write("write your Email: ");
            student.YourEmail = Console.ReadLine();
            Console.Write("That your email? " + "===> ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(student.YourEmail);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" <===\n\n");

            //Show all projective.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");

            Console.Write("That all your projective:\n" + "Full name: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{student.FamilyName}  { student.MiddleName}  { student.Name}\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Group: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{student.NameGroup}\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Your number: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{student.PhoneNumber}\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Email: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{student.YourEmail}\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=\n");

            Console.ReadKey();
        }
    }
    public class Student
    {
        public string NameGroup { get; set; }
        public string FamilyName { get; set; }
        public string MiddleName { get; set; }
        public string Name { get; set; }
        public string YourEmail { get; set; }
        public int PhoneNumber { get; set; }

        public override string ToString()
        {
            return "Full Name: " + $"{FamilyName} {MiddleName} {Name}"
                + " Number Phone: " + PhoneNumber + " Email: " + YourEmail ;
        }
    }
}