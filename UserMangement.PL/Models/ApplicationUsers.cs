using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UserMangement.PL.Models
{
    public class ApplicationUsers:IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string FristName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        public int MyProperty { get; set; }
    }
}
