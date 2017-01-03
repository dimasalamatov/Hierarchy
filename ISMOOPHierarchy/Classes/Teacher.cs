using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy.Interfaces;
using System;

namespace ISMOOPHierarchy.Classes
{
    public class Teacher : IMark
    {
        protected string name;
        protected string surname;
        protected string middlename;
        public Teacher(string sn, string n, string m)
        {
            surname = sn;
            name = n;
            middlename = m;
        }
        public void Mark(Student s)
        {
            Console.WriteLine("Студент " + s.GetSurname + " " + s.GetName);
            Console.Write("Оценка(0-100) - ");
            int mark = int.Parse(Console.ReadLine());
            using (StreamWriter sw = File.AppendText(@"arch.txt"))
            {
                sw.WriteLine(s.GetSurname + "/" + s.GetName + "/" + mark);
            }
        }
        public void Mark(Abiturient a)
        {
            int[] marks = new int[2];
            Console.WriteLine("Абитуриент " + a.GetFullName + "(Факультет - " + a.GetFaculty + ")");
            Console.Write("Оценка за первый екзамен(0-100) - ");
            marks[0] = int.Parse(Console.ReadLine());
            Console.Write("Оценка за второй екзамен(0-100) - ");
            marks[1] = int.Parse(Console.ReadLine());
            a.Marks = marks;
        }
        public Course CreateCourse()
        {
            Console.Write("Название курса - ");
            string cr = Console.ReadLine();
            Course c = new Course(cr);
            return c;
        }

    }
}
