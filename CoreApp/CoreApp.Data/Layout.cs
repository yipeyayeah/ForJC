using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class Layout
    {
        [Key]
        public Guid LayoutId { get; set; }
        [Required]
        public byte[] FileData { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public Guid ModuleId { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

    }
}
