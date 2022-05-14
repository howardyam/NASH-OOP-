using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NASH1.Models;



namespace NASH1.Pages.Orders
{  
    public class StartOrderModel:PageModel
    {
        [BindProperty]
        public InfoModel Info { get; set; }=new InfoModel();

        
        public void OnPost()
        {

        }
    }  
}  