using System.ComponentModel.DataAnnotations;

namespace BlogSite.Entities
{
    public class User
    {
        public int UserID { get; set; }

        [Display(Name = "First Name"), StringLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name"), StringLength(50)]
        public string LastName { get; set; }

        [Display(Name = "UserName"), StringLength(50)]
        public string? UserName { get; set; }

        [Display(Name = "Password"), StringLength(50)]
        public string Password { get; set; }

        [StringLength(50), EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }

        [Display(Name = "Admin")]
        public bool IsAdmin { get; set; }

        [Display(Name = "Create Date")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
    }
}
