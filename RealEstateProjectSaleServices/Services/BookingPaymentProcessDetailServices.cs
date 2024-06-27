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
    public class BookingPaymentProcessDetailServices : IBookingPaymentProcessDetailServices
    {
        private IBookingPaymentProcessDetailRepo _repo;
        public BookingPaymentProcessDetailServices(IBookingPaymentProcessDetailRepo repo)
        {
            _repo = repo;
        }
        public void AddNew(BookingPaymentProcessDetail p)
        {
            _repo.AddNew(p);
        }

        public bool ChangeStatus(BookingPaymentProcessDetail p)
        {
            return _repo.ChangeStatus(p);
        }

        public List<BookingPaymentProcessDetail> GetBookingPaymentProcessDetail()
        {
            return _repo.GetBookingPaymentProcessDetail();
        }

        public BookingPaymentProcessDetail GetBookingPaymentProcessDetailById(Guid id)
        {
            return _repo.GetBookingPaymentProcessDetailById(id);
        }

        public void UpdateBookingPaymentProcessDetail(BookingPaymentProcessDetail p)
        {
            _repo.UpdateBookingPaymentProcessDetail(p);
        }
    }
}
