using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class Operation
    {
        [Key]
        public Guid OperationId { get; set; }
        [Required]
        public Guid TaskId { get; set; }
        [Required]
        public Guid OperationTypeId { get; set; }
        [Required]
        public Guid OperationStatusId { get; set; }
        [Required]
        public Guid ShipmentId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public DateTime CompletionDate { get; set; }
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
