using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NASH1.Models;

namespace NASH1.Pages.Restaurant
{
    


    public class KFCModel : PageModel
    {


        [BindProperty]
        public FoodModel Food { get; set; }
        [BindProperty]
        public InfoModel Info { get; set; }
        public double FoodPrice { get; set; }
        public double KFCBurgerSubPrice { get; set; }
        public double KFCWedgesSubPrice { get; set; }

        public double KFCChickenSubPrice { get; set; }
      
        public string Name { get; set; }      
        public string Email { get; set; }     
        public string Address { get; set; }
        public int Tel { get; set; }

        public double PriceCalculate(int Amount, double price)
        {
            double totalprice = 0.00;

            totalprice = Amount * price;

            return totalprice;
        }
        public double PriceCalculate(int Amount, double price, double discount)
        {
            double totalprice = 0.00;
            if (Amount == 3 | Amount > 3)
            {
                totalprice = Amount * price * discount;
            }
            else
            {
                totalprice = Amount * price;
            }
            return totalprice;

        }
        public IActionResult OnPost()
        {
            KFCBurgerSubPrice += PriceCalculate(Food.KFCBurger, 9.00, 0.90);
            KFCWedgesSubPrice += PriceCalculate(Food.KFCWedges, 10.00);
            KFCChickenSubPrice+= PriceCalculate(Food.KFCChicken, 8.00);
            FoodPrice = KFCChickenSubPrice + KFCBurgerSubPrice + KFCWedgesSubPrice;

            return RedirectToPage("/CheckoutPage/KFCCheckoutPage", new { FoodPrice, Food.KFCBurger, Food.KFCWedges, Food.KFCChicken,KFCBurgerSubPrice,KFCChickenSubPrice,KFCWedgesSubPrice,Info.Name,Info.Email,Info.Address,Info.Tel });
        }

    }


}
