using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy.Classes;

namespace ISMOOPHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Система факультатив");
            Console.WriteLine("2. Система платежи");
            Console.WriteLine("3. Система больница");
            Console.WriteLine("4. Система вступительные екзамены");
            Console.WriteLine("5. Система библиотека");
            Console.Write("Сделайте выбор - ");
            int v = int.Parse(Console.ReadLine());
            switch (v)
            {
                case 1:
                    Teacher t1 = new Teacher("Морозов","Андрей", "Васильевич");
                    Course c = t1.CreateCourse();
                    Student s1 = new Student("Саламатов", "Дмитрий");
                    Student s2 = new Student("Чумак", "Вадим");
                    s1.SignUpCourse(c);
                    s2.SignUpCourse(c);
                    t1.Mark(s1);
                    t1.Mark(s2);
                    break;
                case 2:
                    Client cl1 = new Client("Василий", 11522, 2015, 14789, 0);
                    Client cl2 = new Client("Иван", 11222, 10000, 16689, 0);
                    Administrator ad = new Administrator();
                    cl2.PayOrder(1000);
                    cl1.Transfer(cl2, 15);
                    cl1.PayOrder(5000);
                    cl1.CancelAccount();
                    ad.BlockedCC(cl1);
                    cl2.BlockedCC(cl2);
                    break;
                case 3:
                    Patient p1 = new Patient("Григорий");
                    Nurse n1 = new Nurse("Тамара");
                    Doctor d1 = new Doctor("Виктор", "хирург");
                    d1.Diagnose(p1);
                    d1.TreatPatient(p1);
                    n1.TreatPatient(p1);
                    d1.Discharge(p1);
                    break;
                case 4:
                    Teacher t2 = new Teacher("Иванов", "Иван", "Иванович");
                    Abiturient a1 = new Abiturient("Саламатов","Дмитрий","ФИКТ");
                    Abiturient a2 = new Abiturient("Слепнёв", "Денис", "ФИКТ");
                    t2.Mark(a1);
                    t2.Mark(a2);
                    UniversitySystem.IsEnough(a1);
                    UniversitySystem.IsEnough(a2);
                    break;
                case 5:
                    Reader r1 = new Reader("Саламатов", "Дмитрий");
                    Administrator ad2 = new Administrator();
                    r1.RequestBook();
                    Console.WriteLine(r1.IsHaveBook);
                    ad2.AddInBlackList(r1);
                    break;
                default: Console.WriteLine("ERROR"); break;
            }
        }
    }
}
