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
    public class IndexModel : PageModel
    {
        private readonly MightyGrab.Models.MightyGrabContext _context;

        public IndexModel(MightyGrab.Models.MightyGrabContext context)
        {
            _context = context;
        }

        public IList<BaseGrabModel> BaseGrabModel { get;set; }

        public async Task OnGetAsync()
        {
            BaseGrabModel = await _context.BaseGrabModel.ToListAsync();
        }
    }
}
