using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    public class RentalService
    {
        public double PriceHour { get; set; }
        public double PriceDay { get; set; }
        private ITaxService _taxService;

        public RentalService(double priceHour, double priceDay, ITaxService taxService)
        {
            PriceHour = priceHour;
            PriceDay = priceDay;

            // I can do it, but it's not right yet
            //_taxService = new BrazilTaxService();

            _taxService = taxService;

        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;

            if (duration.TotalHours <= 12)
                basicPayment = Math.Ceiling(duration.TotalHours) * PriceHour;
            else
                basicPayment = Math.Ceiling(duration.TotalDays) * PriceDay;

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

        }
    }
}
