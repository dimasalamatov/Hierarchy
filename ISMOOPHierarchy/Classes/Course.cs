using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Classes
{
    public class Course
    {
        protected string name;
        protected Student[] memebrs = new Student[10];
        protected int count_memb = 0;
        public Course(string n)
        {
            name = n;
        }
        public int  CountMembers
        {
            get { return count_memb; }
            set { count_memb = value; }
        }
        public void AddMem(int x, Student y)
        {
            memebrs[x] = y;
        }

    }
}
