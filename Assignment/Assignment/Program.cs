using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static Student s = new Student();
        static void Main(string[] args)
        {

            printHeader();
            s.getname();
            s.getage();
            s.getphoneno();
            s.getCoursename();
            s.getscore();
            s.Grade = calGrade();

            Console.Write("Name\t\tage\t\tphone no\t\tcourse name\t\tscore\t\tgrade\n");
            Console.WriteLine(s.name + "\t\t" + s.age + "\t\t" + s.phoneNO + "\t\t\t" + s.CourseName + "\t\t\t" + s.Score + "\t\t" + s.Grade);
            Console.ReadLine();

        }
        static void printHeader()
        {
            Console.WriteLine("\t\t\t\t---------------------------------------------");
            Console.WriteLine("\t\t\t\t\t-WELCOME TO GRADE CALCULATOR-");
            Console.WriteLine("\t\t\t\t---------------------------------------------");
        }
        static char calGrade()
        {
            if (s.Score > 90)
                return 'A';
            else if (s.Score > 80)
                return 'B';
            else if (s.Score > 70)
                return 'C';
            else if (s.Score > 60)
                return 'D';
            else
                return 'F';

        }
    }
    class Student
    {
        public string name;
        public int age;
        public string phoneNO;
        public string CourseName;
        public char Grade;
        public int Score;

        public void getname()
        {
            Console.Write("Enter the name of student: ");
            name = Console.ReadLine();

        }
        public void getCoursename()
        {
            Console.Write("Enter the course name: ");
            CourseName = Console.ReadLine();

        }
        public void getage()
        {
            do
            {
                Console.Write("Enter the age of student: ");
                age = int.Parse(Console.ReadLine());
                if (age <= 0)
                    Console.Write("error!!\n");
            } while (age <= 0);

        }
        public void getscore()
        {
            do
            {
                Console.Write("Enter the score of student: ");
                Score = int.Parse(Console.ReadLine());
                if (Score <= 0)
                    Console.Write("error!!\n");
            } while (Score <= 0);

        }
        public void getphoneno()
        {
            Console.Write("Enter the phone number of student: ");
            phoneNO = Console.ReadLine();

        }

    }
}