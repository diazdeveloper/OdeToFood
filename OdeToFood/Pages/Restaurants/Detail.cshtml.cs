using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood
{
    public class DetailModel : PageModel
    {
        #region Properties

        public Restaurant Restaurant { get; set; }

        [TempData]
        public string Message { get; set; }

        #endregion

        private readonly IRestaurantData restaurantData;

        

        public DetailModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restaurantData.GetById(restaurantId);

            //No data found
            if(Restaurant == null)
            {
                return RedirectToPage("./NotFound"); //Action: New Page
            }
            return Page(); //Action: This page with the result
        }
    }
}