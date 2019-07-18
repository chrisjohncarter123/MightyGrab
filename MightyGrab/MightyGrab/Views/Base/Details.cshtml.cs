using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MightyGrab.Models;

namespace MightyGrab.Views.Base
{
    public class DetailsModel : PageModel
    {
        private readonly MightyGrab.Models.MightyGrabContext _context;

        public DetailsModel(MightyGrab.Models.MightyGrabContext context)
        {
            _context = context;
        }

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
    }
}
