﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Catararama_AlexandruV3_lab2.Data;
using Catararama_AlexandruV3_lab2.Models;

namespace Catararama_AlexandruV3_lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Catararama_AlexandruV3_lab2.Data.Catararama_AlexandruV3_lab2Context _context;

        public IndexModel(Catararama_AlexandruV3_lab2.Data.Catararama_AlexandruV3_lab2Context context)
        {
            _context = context;
        }

        public IList<Models.Authors> Authors { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Authors = await _context.Authors.ToListAsync();
        }
    }
}
