using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NASH1.Models;

namespace NASH1.Pages.Restaurant
{



    public class MCDModel : PageModel
    {


        [BindProperty]
        public FoodModel Food { get; set; }
        public double FoodPrice { get; set; }
        public double McdApplePieSubPrice { get; set; }
        public double MCDBurgerSubPrice { get; set; }

        public double MCDFlurrySubPrice { get; set; }
        public double PriceCalculate(int Amount, double price)
        {
            double totalprice = 0.00;

            totalprice = Amount * price;

            return totalprice;
        }
        public double PriceCalculate(int Amount, double price, double discount)
        {
            double totalprice = 0.00;
            if (Amount == 3| Amount > 3)
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
            MCDBurgerSubPrice += PriceCalculate(Food.McBurger, 10.00);
            MCDFlurrySubPrice += PriceCalculate(Food.McFurryOreo, 8.00);
            McdApplePieSubPrice += PriceCalculate(Food.McApplePie, 7.70,0.85);
            FoodPrice = MCDFlurrySubPrice +MCDBurgerSubPrice +McdApplePieSubPrice;
          
            return RedirectToPage("/CheckoutPage/MCDCheckoutPage", new { FoodPrice, Food.McApplePie, Food.McBurger, Food.McFurryOreo, MCDFlurrySubPrice , MCDBurgerSubPrice , McdApplePieSubPrice});
        }

    }
}