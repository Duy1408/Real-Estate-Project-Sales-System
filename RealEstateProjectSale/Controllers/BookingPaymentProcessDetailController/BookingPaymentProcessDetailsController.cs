using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateProjectSaleBusinessObject.BusinessObject;
using RealEstateProjectSaleServices.IServices;

namespace RealEstateProjectSale.Controllers.BookingPaymentProcessDetailController
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingPaymentProcessDetailsController : ControllerBase
    {
        private readonly IBookingPaymentProcessDetailServices _bdetail;

        public BookingPaymentProcessDetailsController(IBookingPaymentProcessDetailServices bdetail)
        {
            _bdetail = bdetail;
        }

        // GET: api/BookingPaymentProcessDetails
        [HttpGet]
        public ActionResult<IEnumerable<BookingPaymentProcessDetail>> GetBookingPaymentProcessDetails()
        {
          if (_bdetail.GetBookingPaymentProcessDetail()==null)
          {
              return NotFound();
          }
            return _bdetail.GetBookingPaymentProcessDetail().ToList();
        }

        // GET: api/BookingPaymentProcessDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookingPaymentProcessDetail>> GetBookingPaymentProcessDetail(Guid id)
        {
          if (_bdetail.GetBookingPaymentProcessDetail() == null)
          {
              return NotFound();
          }
            var bookingPaymentProcessDetail = _bdetail.GetBookingPaymentProcessDetailById(id);

            if (bookingPaymentProcessDetail == null)
            {
                return NotFound();
            }

            return bookingPaymentProcessDetail;
        }

        // PUT: api/BookingPaymentProcessDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookingPaymentProcessDetail(Guid id, BookingPaymentProcessDetail bookingPaymentProcessDetail)
        {
            if (_bdetail.GetBookingPaymentProcessDetail() == null)
            {
                return BadRequest();
            }

        

            try
            {
                _bdetail.UpdateBookingPaymentProcessDetail(bookingPaymentProcessDetail);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_bdetail.GetBookingPaymentProcessDetail() == null)
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

        // POST: api/BookingPaymentProcessDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookingPaymentProcessDetail>> PostBookingPaymentProcessDetail(BookingPaymentProcessDetail bookingPaymentProcessDetail)
        {
          if (_bdetail.GetBookingPaymentProcessDetail() == null)
          {
              return Problem("Entity set 'RealEstateProjectSaleSystemDBContext.BookingPaymentProcessDetails'  is null.");
          }
            _bdetail.AddNew(bookingPaymentProcessDetail);

            return CreatedAtAction("GetBookingPaymentProcessDetail", new { id = bookingPaymentProcessDetail.BookingPaymentProcessDetailID }, bookingPaymentProcessDetail);
        }

        // DELETE: api/BookingPaymentProcessDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookingPaymentProcessDetail(Guid id)
        {
            if (_bdetail.GetBookingPaymentProcessDetail() == null)
            {
                return NotFound();
            }
            var bookingPaymentProcessDetail = _bdetail.GetBookingPaymentProcessDetailById(id);
            if (bookingPaymentProcessDetail == null)
            {
                return NotFound();
            }

            _bdetail.ChangeStatus(bookingPaymentProcessDetail);
            return NoContent();
        }

       
    }
}
