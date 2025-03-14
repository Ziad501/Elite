﻿using System.ComponentModel.DataAnnotations;

namespace Elite.Presentation.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string DisplayOrder { get; set; }
    }
}
