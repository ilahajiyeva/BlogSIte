using System.ComponentModel.DataAnnotations;

namespace BlogSite.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Display(Name ="Category Name"), StringLength(100)]
        public string CategoryName { get; set; }

        [Display(Name = "Category Description")]
        public string? Description { get; set; }

        [Display(Name = "Category Image"), StringLength(100)]
        public string? CategoryImage { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }

        [Display(Name = "Create Date")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        public List<Post>? Posts { get; set; }
    }
}
