using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ContractPayment.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            amount += amount * 0.02;
            return amount;
        }

        public double Interest(double amount, int months)
        {
            return  (((0.01 * months) * amount) + amount);
        }
    }
}
