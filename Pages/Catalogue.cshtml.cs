﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XtendersProject.Pages
{
    public class CatalogueModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Redirect("/Catalogue/index.html?file=test.pdf");
        }
    }
}