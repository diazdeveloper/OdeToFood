using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Data;
using OdeToFood.Core;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace OdeToFood
{
    public class EditModel : PageModel
    {
        private readonly IRestaurantData restaurantData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public IEnumerable<SelectListItem> Cuisines { get; set; }

        

        public EditModel(IRestaurantData restaurantData, IHtmlHelper htmlHelper)
        {
            this.restaurantData = restaurantData;
            this.htmlHelper = htmlHelper;
        }
                
        public IActionResult OnGet(int? restaurantId)
        {

            Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();

            //First look @ the UID for the restaurant
            if (restaurantId.HasValue)
            {
                Restaurant = restaurantData.GetById(restaurantId.Value); 
            }
            else
            {
                Restaurant = new Restaurant();
            }

            //That will return the Restaurnt object (if any)
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            
            return Page(); //Object exists

        }

        public IActionResult OnPost()
        {
            //If invalid return
            if (!ModelState.IsValid)
            {
                Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
                return Page();
            }

            //Valid record from this point on

            var msg = "Restaurnat saved!";

            //Update logic (0 = new record)
            if (Restaurant.Id > 0)
            {
                Restaurant = restaurantData.Update(Restaurant);
            }
            else
            {
                restaurantData.Add(Restaurant); //Add logic
                msg = "Restaurnat added!";
            }


            restaurantData.Commit();
            TempData["Message"] = msg;
            return RedirectToPage("./Detail", new { restaurantId = Restaurant.Id});

        }
        
    }
}