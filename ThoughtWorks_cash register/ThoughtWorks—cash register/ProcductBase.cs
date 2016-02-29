using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoughtWorks_cash_register
{
    /// <summary>
    /// 产品几类
    /// </summary>
    public abstract class ProcductBase
    {
        //名称
        string Name;
        //单价
        double Price = 0.0;
        //折扣率
        double Discount=0.0;
        
    }

}
