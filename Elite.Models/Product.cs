using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name shouldn't be Empty")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be between 3-20 character")]
        [Display(Name = "Category Name")]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string? Description { get; set; } = string.Empty;
        [Required]
        public string? Brand { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Price for 1-50")]
        public decimal Price { get; set; } 
        [Required]
        [Display(Name = "Price 50+")]
        public decimal Price50 { get; set; } 
        [Required]
        [Display(Name = "Price 100+")]
        public decimal Price100 { get; set; } 
    }
}
