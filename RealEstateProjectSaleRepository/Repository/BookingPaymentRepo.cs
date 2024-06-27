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
    public class BookingPaymentRepo : IBookingPaymentRepo
    {
        private readonly BookingPaymentDAO dao;
        public BookingPaymentRepo()
        {
            dao = new BookingPaymentDAO();
        }
        public void AddNew(BookingPayment p)
        {
            dao.AddNew(p);
        }

        public bool ChangeStatus(BookingPayment p)
        {
            return dao.ChangeStatus(p);
        }

        public BookingPayment GetBookingPaymentById(Guid id)
        {
            return dao.GetBookingPaymentByID(id);
        }

        public List<BookingPayment> GetBookingPayments()
        {
            return dao.GetAllBookingPayment();
        }

        public void UpdateBookingPayment(BookingPayment p)
        {
            dao.UpdateBookingPayment(p);
        }
    }
}
