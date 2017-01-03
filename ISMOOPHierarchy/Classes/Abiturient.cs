using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Classes
{
    public  class Abiturient
    {
        protected string name;
        protected string surname;
        protected string faculty;
        int[] marks;
        public Abiturient(string sn, string n, string f)
        {
            surname = sn;
            name = n;
            faculty = f;
        }
        public string GetFullName
        {
            get { return  surname + " " + name; }
        }
        public string GetFaculty
        {
            get { return faculty; }
        }
        public int[] Marks
        {
            get { return marks; }
            set { marks = value; }
        }
    }
}
