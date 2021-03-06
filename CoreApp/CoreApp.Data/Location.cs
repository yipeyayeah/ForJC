﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class Location
    {
        [Key]
        public Guid LocationId { get; set; }
        public string LocationValue { get; set; }
        [Required]
        public string LocationStatus { get; set; }
        [Required]
        public Guid LayoutObjId { get; set; }
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
