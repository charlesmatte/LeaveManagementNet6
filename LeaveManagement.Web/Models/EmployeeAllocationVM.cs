using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Web.Models
{
    public class EmployeeAllocationVM : EmployeeVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    }
}
