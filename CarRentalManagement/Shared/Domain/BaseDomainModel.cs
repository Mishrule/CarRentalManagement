using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
  public abstract class BaseDomainModel
  {
    public int Id { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public string UpdatedBy { get; set; }
    
  }
}
