using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    public class PaymentModel
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public DateTime Month { get; set; }
        public double TotalPayment { get; set; }
    }
}
