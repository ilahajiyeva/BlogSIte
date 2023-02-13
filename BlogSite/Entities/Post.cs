using System.ComponentModel.DataAnnotations;

namespace BlogSite.Entities
{
    public class Post
    {
        public int PostID { get; set; }

        [Display(Name = "Post Name"), StringLength(100)]
        public string PostName { get; set; }

        [Display(Name = "Post Description")]
        public string? Description { get; set; }

        [Display(Name = "Post Image"), StringLength(100)]
        public string? PostImage { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }

        [Display(Name = "Create Date")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;

        [Display(Name = "Update Date")]
        public DateTime? UpdateDate { get; set; } = DateTime.Now;

        [Display(Name = "Category")]
        public int CategoryID { get; set; }
        [Display(Name = "Category")]
        public Category? Category { get; set; }
    }
}
