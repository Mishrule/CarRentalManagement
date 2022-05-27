using System.Collections.Generic;
using System.Threading.Tasks;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BookingsController : ControllerBase
  {
    private readonly IUnitOfWork _unitOfWork;

    public BookingsController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    //GET: /Bookings
    [HttpGet]
    public async Task<IActionResult> GetBookings()
    {
      var includes = new List<string> {"Vehicle", "Customer"};
      var bookings = await _unitOfWork.Bookings.GetAll(includes: includes);
      return Ok(bookings);
    }

    //GET: api/Makes/5
    [HttpGet]
    public async Task<IActionResult> GetBooking(int id)
    {
      var includes = new List<string> {"Vehicle", "Customer"};
      var booking = await _unitOfWork.Bookings.Get(q => q.Id == id, includes);
      if (booking == null)
      {
        return NotFound();
      }

      return Ok(booking);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutMake(int id, Booking booking)
    {
      if (id != booking.Id)
      {
        return BadRequest();
      }

      _unitOfWork.Bookings.Update(booking);
      try
      {
        await _unitOfWork.Save(HttpContext);
      }
        catch (DbUpdateConcurrencyException)
      {
        if (!await BookingExists(id))
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

    [HttpPost]
    public async Task<ActionResult<Booking>> PostBooking(Booking booking)
    {
      await _unitOfWork.Bookings.Insert(booking);
      await _unitOfWork.Save(HttpContext);
      return CreatedAtAction("GetBooking", new {id = booking.Id}, booking);
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBooking(int id)
    {
      var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);
      if (booking == null)
      {
        return NotFound();
      }

      await _unitOfWork.Bookings.Delete(id);
      await _unitOfWork.Save(HttpContext);
      return NoContent();
    }

    private async Task<bool> BookingExists(int id)
    {
      var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);
      return booking == null;
    }

  }
}
