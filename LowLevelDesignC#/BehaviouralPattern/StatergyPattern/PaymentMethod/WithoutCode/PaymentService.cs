using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.StatergyPattern.PaymentMethod.WithoutCode
{

    //Basically there are lot of if conditions
    internal class PaymentService
    {
        public PaymentService() { }

        public void pay(String paymentType)
        {
            if (paymentType == "CreditCard")
            {
                Console.WriteLine("Making Payment using CC");
            }
            else if (paymentType == "DebitCard")
            {
                Console.WriteLine("Debit cARD Payment is made");
            }
            else if (paymentType == "UPI")
            {
                Console.WriteLine("Payment type is not supported");
            }
        }
    }
}
