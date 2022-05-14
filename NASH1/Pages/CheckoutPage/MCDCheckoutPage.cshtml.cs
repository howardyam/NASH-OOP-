using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NASH1.Pages
{
    [BindProperties(SupportsGet = true)]
    public class MCDCheckoutPageModel : PageModel
    {


        public double FoodPrice { get; set; }
        


        //Food amount
       
        public int McBurger { get; set; }
        public int McFurryOreo { get; set; }
        public int McApplePie { get; set; }

    

        //Subprice for each food order


       

        public double McdApplePieSubPrice { get; set; }
        public double MCDBurgerSubPrice { get; set; }

        public double MCDFlurrySubPrice { get; set; }


       
    }
}
