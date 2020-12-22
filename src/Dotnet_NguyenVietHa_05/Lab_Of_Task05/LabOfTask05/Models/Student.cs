using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabOfTask05.Models
{
    public class Student
    {
        public string FamilyName { get; set; }
        public string MiddleName { get; set; }
        public string Name { get; set; }
        public string YourEmail { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime Admission { get; set; }
        public string Faculty { get; set; }
        public int GetCourseNo
        {
            get
            {
                var getCourseNo = DateTime.Today.Year - Admission.Year;
                if (DateTime.Today.Month > 8) getCourseNo++;
                return getCourseNo;
            }
        }
        public int GetSemesterNo
        {
            get
            {
                var getSemesterNo = GetCourseNo * 2;
                if (DateTime.Today.Year > 8 || DateTime.Today.Year < 2) getSemesterNo--;
                return getSemesterNo;
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
    }
}