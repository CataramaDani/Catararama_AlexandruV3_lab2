﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Catararama_AlexandruV3_lab2.Data;
using Catararama_AlexandruV3_lab2.Models;

namespace Catararama_AlexandruV3_lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Catararama_AlexandruV3_lab2.Data.Catararama_AlexandruV3_lab2Context _context;

        public CreateModel(Catararama_AlexandruV3_lab2.Data.Catararama_AlexandruV3_lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Authors Authors { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Authors.Add(Authors);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
