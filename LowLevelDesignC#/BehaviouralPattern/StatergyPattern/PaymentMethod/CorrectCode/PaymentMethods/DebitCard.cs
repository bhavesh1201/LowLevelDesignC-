using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.StatergyPattern.PaymentMethod.CorrectCode.PaymentMethods
{
    internal class DebitCard : IPaymentStatergy
    {
        public void Pay()
        {
            Console.WriteLine("Payment proccesed via debitcard");
        }
    }
}
