using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.StatergyPattern.PaymentMethod.CorrectCode
{
    //This is parent interface which will be implemented by child
    internal interface IPaymentStatergy
    {
        void Pay();
    }
}
