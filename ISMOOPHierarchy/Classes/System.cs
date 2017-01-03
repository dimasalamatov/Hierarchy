using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Classes
{
    public static class UniversitySystem
    {
        public static void IsEnough(Abiturient a)
        {
            int[] arr = a.Marks;
            double sum = 0;
            foreach (int x in arr)
            {
                sum += x;
            }
            sum /= 2;
            if (sum > 70)
            {
                Console.WriteLine("Абитуриент {0} имеет достаточно баллов", a.GetFullName);
            }
            else
            {
                Console.WriteLine("Абитуриент {0} не имеет достаточно баллов", a.GetFullName);
            }
        } 
    }
}
