using NASH1.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NASH1.Models
{
    public class InfoModel
    {

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        public int Tel { get; set; }
    }
}
