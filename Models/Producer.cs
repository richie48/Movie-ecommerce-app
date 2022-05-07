using new_testapp.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace new_testapp.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }


        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile picture required")]
        public string ProfilePictureURL { get; set; }


        [Display(Name ="Full Name")]
        [Required(ErrorMessage = "full name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Fullname should be between 3 and 50 characters")]
        public string FullName { get; set; }



        [Display(Name ="Biography")]
        [Required(ErrorMessage = "Bio is required")]
        public string Bio { get; set; }
    }
}
