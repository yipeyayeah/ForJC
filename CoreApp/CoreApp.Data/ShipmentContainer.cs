using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class ShipmentContainer
    {
        [Key]
        public int ShipmentContainerId { get; set; }
        [Required]
        public Guid ShipmentId { get; set; }
        [Required]
        public Guid ContainerId { get; set; }
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
