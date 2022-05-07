using new_testapp.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace new_testapp.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }



        [Display(Name ="Cinema Logo")]
        public string Logo { get; set; }


        [Display(Name="Cinema Name")]
        public string Name { get; set; }


        [Display(Name="Description")]
        public string Description { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
