using RealEstateProjectSaleBusinessObject.BusinessObject;
using RealEstateProjectSaleDAO.DAOs;
using RealEstateProjectSaleRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleRepository.Repository
{
    public class BookingPaymentProcessDetailRepo : IBookingPaymentProcessDetailRepo
    {
        private BookingPaymentProcessDetailDAO dao;
        public BookingPaymentProcessDetailRepo()
        {
            dao = new BookingPaymentProcessDetailDAO();
        }
        public void AddNew(BookingPaymentProcessDetail p)
        {
            dao.AddNew(p);
        }

        public bool ChangeStatus(BookingPaymentProcessDetail p)
        {
            return dao.ChangeStatus(p);
        }

        public List<BookingPaymentProcessDetail> GetBookingPaymentProcessDetail()
        {
            return dao.GetAllBookingPaymentProcessDetail();
        }

        public BookingPaymentProcessDetail GetBookingPaymentProcessDetailById(Guid id)
        {
            return dao.GetBookingPaymentProcessDetailByID(id);
        }

        public void UpdateBookingPaymentProcessDetail(BookingPaymentProcessDetail p)
        {
            dao.Update(p);
        }
    }
}
