using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApp.Data 
{
   public class Booking
   {
        [Key]
        public Guid BookingId {get; set;}
        [Required]
        public DateTime CompletionDate {get; set;}
        [ForeignKey("Consignee")]
        public Guid ConsigneeId {get; set;}
        [ForeignKey("Client")]
        public Guid ClientId {get; set;}
        [ForeignKey("Shipment")]
        public Guid ShipperId { get; set; }
        [Required]
        public bool IsActive {get; set;}
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    } 
}
