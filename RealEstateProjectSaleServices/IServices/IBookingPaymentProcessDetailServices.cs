using RealEstateProjectSaleBusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleServices.IServices
{
    public interface IBookingPaymentProcessDetailServices
    {

         bool ChangeStatus(BookingPaymentProcessDetail p);


         List<BookingPaymentProcessDetail> GetBookingPaymentProcessDetail();
         void AddNew(BookingPaymentProcessDetail p);


        BookingPaymentProcessDetail GetBookingPaymentProcessDetailById(Guid id);

         void UpdateBookingPaymentProcessDetail(BookingPaymentProcessDetail p);
    }
}
