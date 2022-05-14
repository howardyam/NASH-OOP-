using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NASH1.Pages.CheckoutPage.NicaPlus
{
    [BindProperties(SupportsGet = true)]
    public class NicaPlusCheckoutPageModel : PageModel
    {


        
        public double FoodPrice { get; set; }
       


        //Food amount
        
        public int ChocolateBingsu { get; set; }
        public int MangoBingsu { get; set; }

        //Subprice for each food order


       

        public double ChocolateBingsuSubPrice { get; set; }

        public double MangoBingsuSubPrice { get; set; }
    }
}
