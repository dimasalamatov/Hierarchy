using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Classes
{
    public class Account
    {
        protected double value1;
        protected int num;
        public Account(int n, double v)
        {
            num = n;
            value1 = v;
        }
        public double Value
        {
            get { return value1; }
            set { value1 = value; }
        }
    }
}
