using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy.Interfaces;

namespace ISMOOPHierarchy.Classes
{
   public  class  Administrator : IBlocked
    {
        public bool BlockedCC(Client e)
        {
            e.SetCCBlock = true;
            return true;
        }
        public bool AddInBlackList(Reader r)
        {
            r.BlackList = true;
            return true;
        }
    }
}
