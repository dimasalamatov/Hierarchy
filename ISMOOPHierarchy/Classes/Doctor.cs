using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Classes
{
    public class Doctor : Nurse
    {
        protected string position;
        public Doctor(string n, string p) : base(n)
        {
            name = n;
            position = p;
        }
        public override void TreatPatient(Patient e)
        {
            Console.WriteLine("Пациенту '{0}' была сделана операция", e.GetName);
        }
        public void Diagnose(Patient e)
        {
            e.Diagnosis = Console.ReadLine();
        }
        public void Discharge(Patient e)
        {
            e.IsInHospital = false;
        }
    }
}
