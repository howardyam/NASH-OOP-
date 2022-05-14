using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace NASH1.Pages.Checkout
{

    [BindProperties(SupportsGet = true)]
    public class KFCCheckoutPageModel : PageModel
    {
        
        
      
        public double FoodPrice { get; set; }
     


        //Food amount
        public int KFCBurger { get; set; }

        public int KFCWedges { get; set; }

        public int KFCChicken { get; set; }
       

        //Subprice for each food order


        public double KFCBurgerSubPrice { get; set; }
        public double KFCWedgesSubPrice { get; set; }

        public double KFCChickenSubPrice { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Tel { get; set; }

    }
}
