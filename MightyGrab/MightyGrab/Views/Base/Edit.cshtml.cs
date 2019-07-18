using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MightyGrab.Models;

namespace MightyGrab.Views.Base
{
    public class EditModel : PageModel
    {
        private readonly MightyGrab.Models.MightyGrabContext _context;

        public EditModel(MightyGrab.Models.MightyGrabContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BaseGrabModel BaseGrabModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BaseGrabModel = await _context.BaseGrabModel.FirstOrDefaultAsync(m => m.ID == id);

            if (BaseGrabModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BaseGrabModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BaseGrabModelExists(BaseGrabModel.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BaseGrabModelExists(int id)
        {
            return _context.BaseGrabModel.Any(e => e.ID == id);
        }
    }
}
