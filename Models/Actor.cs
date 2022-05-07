using new_testapp.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace new_testapp.Models
{
    public class Actor:IEntityBase
    {
        //The values in the id key will simply be overwritten by the id field in ientitybase
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureURL { get; set; }


        [Display(Name ="FullName")]
        [Required(ErrorMessage = "Fullname is required")]
        [StringLength(50, MinimumLength =3,ErrorMessage ="Fullname should be between 3 and 50 characters")]
        public string FullName { get; set; }


        [Display(Name ="Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }


        public List<Actor_Movie> Actors_Movie { get; set; }
    }
}
