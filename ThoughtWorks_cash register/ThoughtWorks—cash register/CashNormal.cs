using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoughtWorks_cash_register
{
    class CashNormal :CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}
