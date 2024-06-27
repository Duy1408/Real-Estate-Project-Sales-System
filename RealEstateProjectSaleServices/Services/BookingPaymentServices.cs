using RealEstateProjectSaleBusinessObject.BusinessObject;
using RealEstateProjectSaleRepository.IRepository;
using RealEstateProjectSaleServices.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleServices.Services
{
    public class BookingPaymentServices : IBookingPaymentServices
    {
        private IBookingPaymentRepo _repo;
        public BookingPaymentServices(IBookingPaymentRepo repo)
        {
            _repo = repo;
        }
        public void AddNew(BookingPayment p)
        {
            _repo.AddNew(p);
        }

        public bool ChangeStatus(BookingPayment p)
        {
            return _repo.ChangeStatus(p);
        }

        public BookingPayment GetBookingPaymentById(Guid id)
        {
            return _repo.GetBookingPaymentById(id);
        }

        public List<BookingPayment> GetBookingPayments()
        {
            return _repo.GetBookingPayments();
        }

        public void UpdateBookingPayment(BookingPayment p)
        {
            _repo.UpdateBookingPayment(p);
        }
    }
}
