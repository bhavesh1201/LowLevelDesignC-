using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.StatergyPattern.PaymentMethod.CorrectCode
{

    //first we are creating a object of parent or interface which will call the payment method
    internal class PaymentService
    {
        public IPaymentStatergy paymentStatergy;

        public PaymentService(IPaymentStatergy paymentStatergy)
        {
            this.paymentStatergy = paymentStatergy;
        }
        public void Pay() {
            paymentStatergy.Pay();
        }
    }
}
