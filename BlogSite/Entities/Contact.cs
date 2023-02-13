using System.ComponentModel.DataAnnotations;

namespace BlogSite.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }

        [Display(Name = "First Name"), StringLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name"), StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50), EmailAddress]
        public string? Email { get; set; }

        [Display(Name = "Message"), StringLength(500)]
        public string Message { get; set; }

        [Display(Name = "Message"), StringLength(20)]
        public string? Phone { get; set; }

        [Display(Name = "Create Date")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
    }
}
