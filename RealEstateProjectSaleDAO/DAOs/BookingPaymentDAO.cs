using Microsoft.EntityFrameworkCore;
using RealEstateProjectSaleBusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleDAO.DAOs
{
    public class BookingPaymentDAO

    {
        private static BookingPaymentDAO instance;

        public static BookingPaymentDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookingPaymentDAO();
                }
                return instance;
            }


        }

        public List<BookingPayment> GetAllBookingPayment()
        {
            var _context = new RealEstateProjectSaleSystemDBContext();
            return _context.BookingPayments.ToList();
        }

        public bool AddNew(BookingPayment p)
        {
            var _context = new RealEstateProjectSaleSystemDBContext();
            var a = _context.BookingPayments.SingleOrDefault(c => c.BookingPaymentID == p.BookingPaymentID);

            if (a != null)
            {
                return false;
            }
            else
            {
                _context.BookingPayments.Add(p);
                _context.SaveChanges();
                return true;

            }
        }

        public bool UpdateBookingPayment(BookingPayment p)
        {
            var _context = new RealEstateProjectSaleSystemDBContext();
            var a = _context.BookingPayments.SingleOrDefault(c => c.BookingPaymentID == p.BookingPaymentID);

            if (a == null)
            {
                return false;
            }
            else
            {
                _context.Entry(a).CurrentValues.SetValues(p);
                _context.SaveChanges();
                return true;
            }
        }

        public bool ChangeStatus(BookingPayment p)
        {
            var _context = new RealEstateProjectSaleSystemDBContext();
            var a = _context.BookingPayments.FirstOrDefault(c => c.BookingPaymentID.Equals(p.BookingPaymentID));


            if (a == null)
            {
                return false;
            }
            else
            {
                _context.Entry(a).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
        }

        public BookingPayment GetBookingPaymentByID(Guid id)
        {
            var _context = new RealEstateProjectSaleSystemDBContext();
            return _context.BookingPayments.SingleOrDefault(a => a.BookingPaymentID == id);
        }

    }
}
