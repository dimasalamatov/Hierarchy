using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Classes
{
   public class CreditCard
    {
        protected double value1;
        protected int num;
        protected bool blocked = false;
        public CreditCard(int n, double v)
        {
            num = n;
            value1 = v;
        }
        public double Value
        {
            get { return value1; }
            set { value1 = value; }
        }
        public bool IsBlocked
        {
            get { return blocked; }
            set { blocked = value; }
        }
    }
}
