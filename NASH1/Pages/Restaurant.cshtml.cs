using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NASH1.Models;



namespace NASH1.Pages.Orders
{
   

    public class FoodOrder  
    {
        public List<FoodModel> Restaurants = new List<FoodModel>();
        public void AddRestaurant(string restaurantName, string restaurantpicture,string restaurantpage)
        {
            if(restaurantpage == null)
            {
                restaurantpage = "KFC";
            }
            Restaurants.Add(new FoodModel

            {
                RestaurantName = restaurantName,
                RestaurantImage = restaurantpicture,
                Pagename = restaurantpage

            });

        }

    }
    public class RestaurantModel : PageModel
    {
        public FoodOrder Menus = new FoodOrder();
        public RestaurantModel()
        {

            Menus.AddRestaurant("KFC", "KFC","KFC");
            Menus.AddRestaurant("MCD", "MCD","MCD");
            Menus.AddRestaurant("NicaPlus", "NicaPlus","NicaPlus");



        }
    }
}
       




    
