using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleBusinessObject.BusinessObject
{
    public class BookingPaymentProcessDetail
    {
        public Guid BookingID { get; set; }
        public Guid BookingPaymentProcessID { get; set; }
        public string Paymentprogress { get; set; }
        public DateTime Paymentduedate { get; set; }
        public int Customervaluepaid { get; set; }
        public string Note { get; set; }




    }
}
