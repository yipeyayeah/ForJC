using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data {
    public class ItemCargo
    {
        [Key]
        public int ItemCargoId { get; set; }
        [Required]
        public Guid CargoId { get; set; }
        [Required]
        public Guid ItemId { get; set; }
        [Required]
        public int Quantity { get; set; }
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
