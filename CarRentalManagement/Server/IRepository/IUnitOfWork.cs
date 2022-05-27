using System;
using System.Threading.Tasks;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;

namespace CarRentalManagement.Server.IRepository
{
  public interface IUnitOfWork : IDisposable
  {
    Task Save(HttpContext httpContext);
    IGenericRepository<Make> Makes { get;  }
    IGenericRepository<Model> Models { get; }
    IGenericRepository<Vehicle> Vehicles { get; }
    IGenericRepository<Colour> Colours { get; }
    IGenericRepository<Booking> Bookings { get; }
    IGenericRepository<Customer> Customers { get; }
  }
}
