using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateProjectSaleBusinessObject.BusinessObject;
using RealEstateProjectSaleServices.IServices;

namespace RealEstateProjectSale.Controllers.BookingPaymentController
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingPaymentsController : ControllerBase
    {
        private readonly IBookingPaymentServices _pmt;

        public BookingPaymentsController(IBookingPaymentServices pmt)
        {
            _pmt = pmt;
        }

        // GET: api/BookingPayments
        [HttpGet]
        public ActionResult<IEnumerable<BookingPayment>> GetBookingPayments()
        {
          if (_pmt.GetBookingPayments()==null)
          {
              return NotFound();
          }
            return _pmt.GetBookingPayments().ToList();
        }

        // GET: api/BookingPayments/5
        [HttpGet("{id}")]
        public ActionResult<BookingPayment> GetBookingPayment(Guid id)
        {
          if (_pmt.GetBookingPayments() == null)
          {
              return NotFound();
          }
            var bookingPayment = _pmt.GetBookingPaymentById(id);

            if (bookingPayment == null)
            {
                return NotFound();
            }

            return bookingPayment;
        }

        // PUT: api/BookingPayments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutBookingPayment(Guid id, BookingPayment bookingPayment)
        {
            if (_pmt.GetBookingPayments() == null)
            {
                return BadRequest();
            }

        

            try
            {
                _pmt.UpdateBookingPayment(bookingPayment);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_pmt.GetBookingPayments() == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BookingPayments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<BookingPayment> PostBookingPayment(BookingPayment bookingPayment)
        {
          if (_pmt.GetBookingPayments() == null)
          {
              return Problem("Entity set 'RealEstateProjectSaleSystemDBContext.BookingPayments'  is null.");
          }
            _pmt.AddNew(bookingPayment);

            return CreatedAtAction("GetBookingPayment", new { id = bookingPayment.BookingPaymentID }, bookingPayment);
        }

        // DELETE: api/BookingPayments/5
        [HttpDelete("{id}")]
        public IActionResult DeleteBookingPayment(Guid id)
        {
            if (_pmt.GetBookingPayments() == null)
            {
                return NotFound();
            }
            var bookingPayment = _pmt.GetBookingPaymentById(id);
            if (bookingPayment == null)
            {
                return NotFound();
            }

            _pmt.ChangeStatus(bookingPayment);

            return NoContent();
        }

     
    }
}
