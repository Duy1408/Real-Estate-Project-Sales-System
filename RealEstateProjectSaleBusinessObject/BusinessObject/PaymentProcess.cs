using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleBusinessObject.BusinessObject
{
    public class PaymentProcess
    {
        public Guid PaymentProcessID { get; set; }
        public string Paymentperiod { get; set; }
        public string Duration { get; set; }
        public int PaymentRate { get; set; }


    }
}
