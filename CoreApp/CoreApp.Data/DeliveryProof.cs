using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data 
{
    public class DeliveryProof
    {
        [Key]
        public Guid DeliveryProofId { get; set; }

        [Required]
        public Guid DeliveryId { get; set; }
        [Required]
        public string DeliverySignature { get; set; }
        [Required]
        public string DeliveryPicture { get; set; }
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