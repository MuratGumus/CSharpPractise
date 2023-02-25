using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0027_StudentInfoNoteSchool
{
    public class Students
    {
        private int studentNumber;
        private string studentName;
        private string studentSurname;
        private int midterm1;
        private int midterm2;
        private int final;
        private string school;

        public Students(int _studentNumber, string _studentName, string _studentSurname, int _midterm1, int _midterm2, int _final, string _school)
        {
            studentNumber = _studentNumber;
            studentName = _studentName;
            studentSurname= _studentSurname;
            midterm1 = _midterm1;
            midterm2 = _midterm2;
            final = _final;
            school = _school;

        }



        public void studentInfo()
        {
            Console.WriteLine($"Student number is {studentNumber}");
            Console.WriteLine($"Student name is {studentName}");
            Console.WriteLine($"Student surname is {studentSurname}");
            Console.WriteLine($"Student midterm1 is {midterm1}");
            Console.WriteLine($"Student midterm2 is {midterm2}");
            Console.WriteLine($"Student final is {final}");


        }

        public double noteAvarage()
        {
            double noteAvarage = midterm1 * 20 / 100 + midterm2 * 20 / 100 + final * 60 / 100;
  
            return noteAvarage;
        }

        public void schoolName()
        {
            Console.WriteLine($"School name is {school}");
        }
    }
}
