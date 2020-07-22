using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Core
{

    public class Restaurant
    {

        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Location (City)")]
        public string Location { get; set; }

        public CuisineType Cuisine { get; set; }

    }
}
