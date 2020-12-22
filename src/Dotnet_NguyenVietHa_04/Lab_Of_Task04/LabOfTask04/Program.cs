using LabOfTask01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOfTask04
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new ExtendedStudent();
            //For full name.
            Console.Write("Family Name: ");
            student.FamilyName = Console.ReadLine();
            Console.Write("Middle Name: ");
            student.MiddleName = Console.ReadLine();
            Console.Write("Name: ");
            student.Name = Console.ReadLine();
            //For phone number and email.
            Console.Write("PhoneNumber: ");
            student.PhoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Email: ");
            student.YourEmail = Console.ReadLine();
            //For birthdate and admission.
            Console.Write("Enter your birthdate (Example: 19xx.01.01): ");
            DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
            student.BirthDate = inputtedDate;
            Console.Write("Enter date of admissions (Example: 20xx.01.01): ");
            DateTime inputtedDate0 = DateTime.Parse(Console.ReadLine());
            student.Admission = inputtedDate0;
            //For faculty and specialty.
            Console.Write("Enter your faculty name: ");
            student.Faculty = Console.ReadLine();
            Console.Write("Enter your specialty number: ");
            student.SpecialtyNumber = Console.ReadLine();
            //Show all output
            Console.WriteLine("==============================");
            Console.WriteLine(student.ToString());

            Console.ReadKey();

        }
        //Extended from studen in LabOfTask01.
        public class ExtendedStudent : Student
        {
            public DateTime BirthDate { get; set; }
            public DateTime Admission { get; set; }
            public string Faculty { get; set; }
            public string SpecialtyNumber { get; set; }
            public int GetCourseNo
            {
                get
                {
                    var getCourseNo = DateTime.Today.Year - Admission.Year;
                    if (DateTime.Today.Month > 8) getCourseNo++ ;
                    return getCourseNo;
                }
            }
            public int GetSemesterNo
            {
                get
                {
                    var getSemesterNo = GetCourseNo * 2;
                    if (DateTime.Today.Year > 8 || DateTime.Today.Year < 2) getSemesterNo-- ;
                    return getSemesterNo;
                }
            }
            public String GetGroupName
            {
                get
                {
                    return $"{Faculty}--{SpecialtyNumber}--{Admission.ToString("yy")}";
                }
            }
            public int GetCurrentAge
            {
                get
                {
                    var getCurrentAge = DateTime.Today.Year - BirthDate.Year;
                    if (BirthDate.Date > DateTime.Today.AddYears(-getCurrentAge)) getCurrentAge--;
                    return getCurrentAge;
                }
            }
            public override string ToString()
            {
                var stringBuilder = new StringBuilder();

                stringBuilder.AppendLine($"Your group: {GetGroupName}");
                stringBuilder.AppendLine($"Full name: {FamilyName} {MiddleName} {Name}");
                stringBuilder.AppendLine($"Number phone: {PhoneNumber}\t\t Email: {YourEmail}");
                stringBuilder.AppendLine($"Your birthday: {BirthDate.ToString("yyyy.MM.dd")}\t\t Age: {GetCurrentAge}");
                stringBuilder.AppendLine($"Date of admission: {Admission.ToString("yyyy.MM.dd")}");
                stringBuilder.AppendLine($"Faculty: {Faculty}");
                stringBuilder.AppendLine($"Specialty No: {SpecialtyNumber}");
                stringBuilder.AppendLine($"Course No: {GetCourseNo}\tSemester No:{GetSemesterNo}");
                stringBuilder.AppendLine("------------------------------");

                return stringBuilder.ToString();
            }

        }
    }
}
