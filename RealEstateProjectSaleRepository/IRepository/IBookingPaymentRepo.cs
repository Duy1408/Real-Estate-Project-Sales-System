using RealEstateProjectSaleBusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleRepository.IRepository
{
    public interface IBookingPaymentRepo
    {
        public bool ChangeStatus(BookingPayment p);


        public List<BookingPayment> GetBookingPayments();
        public void AddNew(BookingPayment p);


        public BookingPayment GetBookingPaymentById(Guid id);

        public void UpdateBookingPayment(BookingPayment p);
    }
}
