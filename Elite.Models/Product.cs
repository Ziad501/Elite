using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elite.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name shouldn't be Empty")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3-20 character")]
        [Display(Name = "Category Name")]
        public string ProductName { get; set; } 
        [Required]
        public string Description { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        [Display(Name = "Price for 1-50")]
        public double Price { get; set; } 
        [Required]
        [Display(Name = "Price 50+")]
        public double Price50 { get; set; } 
        [Required]
        [Display(Name = "Price 100+")]
        public double Price100 { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]

        public Category? Category { get; set; }
        public string? ImageUrl { get; set; }
    }
}
