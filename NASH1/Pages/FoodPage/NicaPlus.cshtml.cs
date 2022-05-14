using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NASH1.Models;

namespace NASH1.Pages.Restaurant
{



    public class NicaPlusModel : PageModel
    {


        [BindProperty]
        public FoodModel Food { get; set; }
        public double FoodPrice { get; set; }
        public double ChocolateBingsuSubPrice { get; set; }

        public double MangoBingsuSubPrice { get; set; }
        public double PriceCalculate(int Amount, double price)
        {
            double totalprice = 0.00;

            totalprice = Amount * price;

            return totalprice;
        }
        public double PriceCalculate(int Amount, double price, double discount)
        {
            double totalprice = 0.00;
            if (Amount == 2 | Amount > 2)
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
            ChocolateBingsuSubPrice += PriceCalculate(Food.ChocolateBingsu, 12.30);
            MangoBingsuSubPrice += PriceCalculate(Food.MangoBingsu, 14.30, 0.85);

            FoodPrice = MangoBingsuSubPrice + ChocolateBingsuSubPrice;



            return RedirectToPage("/CheckoutPage/NicaPlusCheckoutPage", new { FoodPrice, Food.MangoBingsu, Food.ChocolateBingsu, MangoBingsuSubPrice, ChocolateBingsuSubPrice });
       
        }

    }
}