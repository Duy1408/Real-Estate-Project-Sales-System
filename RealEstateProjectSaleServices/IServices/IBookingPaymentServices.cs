using RealEstateProjectSaleBusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleServices.IServices
{
    public interface IBookingPaymentServices
    {
         bool ChangeStatus(BookingPayment p);


         List<BookingPayment> GetBookingPayments();
       void AddNew(BookingPayment p);


         BookingPayment GetBookingPaymentById(Guid id);

         void UpdateBookingPayment(BookingPayment p);
    }
}
