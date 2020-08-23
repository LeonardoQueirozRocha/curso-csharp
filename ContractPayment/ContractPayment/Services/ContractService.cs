using ContractPayment.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContractPayment.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double amount = 0.0;
            for (int i = 1; i <= months; i++)
            {
                amount = contract.TotalValue / months;
                amount = _onlinePaymentService.Interest(amount, i);
                amount = _onlinePaymentService.PaymentFee(amount);
                contract.AddInstallment(new Installment(contract.Date.AddMonths(i), amount));
            }
        }
    }
}
