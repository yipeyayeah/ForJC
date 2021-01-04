using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class Exception
    {
        [Key]
        public Guid ExceptionId { get; set; }
        [Required]
        public Guid ExceptionTypeId { get; set; }
        [Required]
        public Guid OperationId { get; set; }
        [Required]
        public Guid BookingId { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
