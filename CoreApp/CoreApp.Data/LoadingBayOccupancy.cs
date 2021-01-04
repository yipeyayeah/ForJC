﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class LoadingBayOccupancy
    {
        [Key]
        public Guid LoadingBayOccupancyID { get; set; }
        [Required]
        public Guid LoadingBayId { get; set; }
        [Required]
        public string DisplayValue { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public DateTime StatusTime { get; set; }
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
