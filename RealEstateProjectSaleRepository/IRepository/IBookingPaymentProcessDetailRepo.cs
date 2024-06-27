using RealEstateProjectSaleBusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleRepository.IRepository
{
    public interface IBookingPaymentProcessDetailRepo
    {
        public bool ChangeStatus(BookingPaymentProcessDetail p);


        public List<BookingPaymentProcessDetail> GetBookingPaymentProcessDetail();
        public void AddNew(BookingPaymentProcessDetail p);


        public BookingPaymentProcessDetail GetBookingPaymentProcessDetailById(Guid id);

        public void UpdateBookingPaymentProcessDetail(BookingPaymentProcessDetail p);
    }
}
