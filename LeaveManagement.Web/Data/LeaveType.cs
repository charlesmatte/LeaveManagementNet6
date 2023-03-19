using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Data
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }

        [Required]
        public int DefaultDays { get; set; }
    }
}
