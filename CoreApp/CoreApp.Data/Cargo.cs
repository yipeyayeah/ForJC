using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApp.Data
{
    public class Cargo
    {
        [Key]
        public Guid CargoId { get; set; }
        [ForeignKey("CargoDetail")]
        public Guid CargoDetailId { get; set; }
        [ForeignKey("Measurement")]
        public Guid MeasurementId { get; set; }
        [ForeignKey("PackagingType")]
        public Guid PackagingTypeId { get; set; }
        [ForeignKey("Location")]
        public Guid LocationId { get; set; }
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
