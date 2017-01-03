using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy.Interfaces;

namespace ISMOOPHierarchy.Classes
{
    public class Client : IBlocked
    {
        protected string name;
        protected Account ac;
        protected CreditCard cc;
        public Client(string n, int num, double val, int numc, double valc)
        {
            name = n;
            ac = new Account(num, val);
            cc = new CreditCard(numc, valc);
        }
        public void PayOrder(double price)
        {
            Console.WriteLine("1. Снять деньги со счета");
            Console.WriteLine("2. Снять деньги из КК");
            int v = int.Parse(Console.ReadLine());
            switch(v)
            {
                case 1:
                    if (price > ac.Value)
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    else
                    {
                        ac.Value -= price;
                    }
                    break;
                case 2:
                    cc.Value += price;
                    break;
            }
            
        }
        public bool Transfer(Client e, double sum)
        {
            if (sum > ac.Value)
            {
                Console.WriteLine("Недостаточно средств");
                return false;
            }
            else
            {
                ac.Value -= sum;
                e.ac.Value += sum;
                return true;
            }
        } 
        public bool CancelAccount()
        {
            ac.Value = 0;
            return true;
        }
        public bool BlockedCC(Client e)
        {
            e.cc.IsBlocked = true;
            return true;
        }
        public bool SetCCBlock
        {
            set { cc.IsBlocked = value; }
        }
        }
    }

