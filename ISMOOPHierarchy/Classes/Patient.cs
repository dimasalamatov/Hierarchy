using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Classes
{
    public class Patient
    {
        protected string name;
        protected string diagnosis;
        protected bool in_hospatal = true;
        public Patient(string n)
        {
            name = n;
        }
        public string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value; }
        }
        public bool IsInHospital
        {
            get { return in_hospatal; }
            set { in_hospatal = value; }
        }
        public string GetName
        {
            get { return name; }
        }
    }
}
