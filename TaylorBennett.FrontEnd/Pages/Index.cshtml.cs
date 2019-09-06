using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TaylorBennett.FrontEnd.Pages
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public bool ShowMessage => !string.IsNullOrEmpty(Message);
        public void OnGet()
        {

        }
    }
}
