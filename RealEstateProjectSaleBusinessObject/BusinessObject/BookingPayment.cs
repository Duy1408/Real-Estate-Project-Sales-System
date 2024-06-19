using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleBusinessObject.BusinessObject
{
    public class BookingPayment
    {
        public Guid BookingPaymentID { get; set; }
        public Guid CustomerID { get; set; }
        public Guid PaymentTypeID { get; set; }
        public Guid ProjectID { get; set; }
        public int Deposittoholdprọject { get; set; }
        public bool Status { get; set; }


    }
}
