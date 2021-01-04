using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApp.Data
{
    public class BillOfLading
    {
        [Key]
        public Guid BillOfLadingId { get; set; }
        [ForeignKey("Shipment")]
        public Guid ShipmentId { get; set; }
        [Required]
        public string Country { get; set; }
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