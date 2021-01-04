using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApp.Data {
    public class Alert
    {
        [Key]
        public Guid AlertId { get; set; }
        [Required]
        public string Message { get; set; }
        [ForeignKey("Record")]
        public Guid RecordId { get; set; }
        [Required]
        public string ActionTaken { get; set; }
        [Required]
        public string ActionBy { get; set; }
        [Required]
        public string Status { get; set; }
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
