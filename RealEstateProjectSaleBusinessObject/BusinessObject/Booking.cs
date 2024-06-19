using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleBusinessObject.BusinessObject
{
    public class Booking
    {
        public Guid BookingID { get; set; }
        public string Address { get; set; }
        public DateTime Dateofsignature { get; set; }
        public byte[] BookingFile { get; set; }
        public bool Status { get; set; }
    }
}
