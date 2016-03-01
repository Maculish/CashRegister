using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoughtWorks_cash_register
{
    class CashDiscount:CashSuper
    {
        double dicount = 0.0;
        public CashDiscount(double firstCondition, double secondCondition)
        { 
            
        }
        public override double AcceptCash(double money)
        {
            throw new NotImplementedException();
        }
    }
}
