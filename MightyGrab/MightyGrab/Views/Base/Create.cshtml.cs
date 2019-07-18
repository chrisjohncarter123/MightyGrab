using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MightyGrab.Models;

namespace MightyGrab.Views.Base
{
    public class CreateModel : PageModel
    {
        private readonly MightyGrab.Models.MightyGrabContext _context;

        public CreateModel(MightyGrab.Models.MightyGrabContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BaseGrabModel BaseGrabModel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BaseGrabModel.Add(BaseGrabModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}