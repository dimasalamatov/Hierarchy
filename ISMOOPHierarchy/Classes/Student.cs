using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Classes
{
    public class Student
    {
        protected string name;
        protected string surname;
        public Student(string sn, string n)
        {
            surname = sn;
            name = n;
        }
        public string GetName
        {
            get { return name; }
        }
        public string GetSurname
        {
            get { return surname; }
        }
        public void SignUpCourse(Course c)
        {
            if (c.CountMembers > 10)
            {
                Console.WriteLine("Мест нет!");
            }
            else
            {
                c.AddMem(c.CountMembers, this);
                c.CountMembers++;
            }
        }
    }
}
