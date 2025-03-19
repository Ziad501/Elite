using System.ComponentModel.DataAnnotations;

namespace Elite.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Name shouldn't be Empty")]
        [StringLength(20, MinimumLength = 3,ErrorMessage ="Name must be between 3-20 character")]
        [Display(Name = "Category Name")]
        public string Name { get; set; }= string.Empty;
        [Display(Name = "Display Order")]
        [Range(1,100, ErrorMessage = "Display Order must be between 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}
