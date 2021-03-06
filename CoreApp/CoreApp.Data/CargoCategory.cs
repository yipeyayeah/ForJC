using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class CargoCategory
    {
        [Key]
        public Guid CargoCategoryId { get; set; }
        [Required]
        public Guid CargoId { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
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