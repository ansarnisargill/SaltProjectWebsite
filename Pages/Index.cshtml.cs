using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using XtendersProject.Data;

namespace XtendersProject.Pages
{
    public class IndexModel : PageModel
    {
    private Context _context;

        public IActionResult OnGet()
        {
           
                return Page();
        }
        public IndexModel(Context contex)
        {
            _context=contex;
        }
    }
}
