﻿using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Core
{

    public class Restaurant
    {

        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        [StringLength(25)]
        public string Location { get; set; }

        public CuisineType Cuisine { get; set; }

    }
}