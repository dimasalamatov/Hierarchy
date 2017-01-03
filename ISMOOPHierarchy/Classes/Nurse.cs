using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Classes
{
    public class Nurse
    {
        protected string name;
        public Nurse(string n)
        {
            name = n;
        }
        public virtual void TreatPatient(Patient e)
        {
            Console.WriteLine("Пациенту '{0}' был сделан укол", e.GetName);
        }
    }
}
