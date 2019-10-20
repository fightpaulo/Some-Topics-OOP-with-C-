using InterfacesExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise.Services
{
    public class ContractService
    {
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int installmentNumbers)
        {
            double basicQuota = contract.TotalValue / installmentNumbers;

            for (int i = 0; i < installmentNumbers; i++)
            {
                DateTime data = contract.Date.AddMonths(i + 1);
                double updateQuota = basicQuota + _paymentService.Interest(basicQuota, i + 1);
                double fullQuota = updateQuota + _paymentService.Fee(updateQuota);
                contract.AddInstallment(new Installment(data, fullQuota));
            }
        }
    }
}
