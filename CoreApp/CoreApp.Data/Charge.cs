using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class Charge
    {
        [Key]
        public Guid ChargeId { get; set; }
        [Required]
        public Guid ChargeTypeId { get; set; }
        [Required]
        public Guid BookingId { get; set; }
        [Required]
        public double Cost { get; set; }
        [Required]
        public Guid ChargeStatusId { get; set; }
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
