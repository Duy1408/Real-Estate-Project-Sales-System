using Microsoft.EntityFrameworkCore;
using RealEstateProjectSaleBusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleDAO.DAOs
{
    public class BookingPaymentProcessDetailDAO
    {
        private static BookingPaymentProcessDetailDAO instance;

        public static BookingPaymentProcessDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookingPaymentProcessDetailDAO();
                }
                return instance;
            }


        }

        public List<BookingPaymentProcessDetail> GetAllBookingPaymentProcessDetail()
        {
            var _context = new RealEstateProjectSaleSystemDBContext();
            return _context.BookingPaymentProcessDetails.ToList();
        }

        public bool AddNew(BookingPaymentProcessDetail p)
        {
            var _context = new RealEstateProjectSaleSystemDBContext();
            var a = _context.BookingPaymentProcessDetails.SingleOrDefault(c => c.BookingPaymentProcessDetailID == p.BookingPaymentProcessDetailID);

            if (a != null)
            {
                return false;
            }
            else
            {
                _context.BookingPaymentProcessDetails.Add(p);
                _context.SaveChanges();
                return true;

            }
        }

        public bool Update(BookingPaymentProcessDetail p)
        {
            var _context = new RealEstateProjectSaleSystemDBContext();
            var a = _context.BookingPaymentProcessDetails.SingleOrDefault(c => c.BookingPaymentProcessDetailID == p.BookingPaymentProcessDetailID);

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

        public bool ChangeStatus(BookingPaymentProcessDetail p)
        {
            var _context = new RealEstateProjectSaleSystemDBContext();
            var a = _context.BookingPaymentProcessDetails.FirstOrDefault(c => c.BookingPaymentProcessDetailID.Equals(p.BookingPaymentProcessDetailID));


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
        public BookingPaymentProcessDetail GetBookingPaymentProcessDetailByID(Guid id)
        {
            var _context = new RealEstateProjectSaleSystemDBContext();
            return _context.BookingPaymentProcessDetails.SingleOrDefault(a => a.BookingPaymentProcessDetailID == id);
        }
    }
}
