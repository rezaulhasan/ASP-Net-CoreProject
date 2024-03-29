using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using RestaurantReviewApp.Data;
using RestaurantReviewApp.Core; 

namespace RestaurantReviewApp.Pages.Restaurant
{
    public class ListModel : PageModel
    {
        public string Message { get; set; }
        public IEnumerable<Restaurants> Restaurants { get; set; }

        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData; 

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }

        public void OnGet()
        {
            Message = config ["Message"];
            Restaurants = restaurantData.GetAll(); 
        }
    }
}
