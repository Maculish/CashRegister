using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoughtWorks_cash_register
{
    class CashRebate : CashSuper
    {
        /// <summary>
        /// 折扣率
        /// </summary>
        double moneyRebate;
        public CashRebate(double moneyRebate) {
            this.moneyRebate = moneyRebate;
        }
        public override double AcceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
