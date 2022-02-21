using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB1001_WebApplication.Pages
{

    public class IntroModel : PageModel
    {
        [FromQuery(Name = "firstValue")]
        public int firstValue { get; set; }


        [FromQuery(Name = "secondValue")]
        public int secondValue { get; set; }

        public void OnGet()
        {
        }
    }
}
