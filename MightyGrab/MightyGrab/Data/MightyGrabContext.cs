using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MightyGrab.Models
{
    public class MightyGrabContext : DbContext
    {
        public MightyGrabContext (DbContextOptions<MightyGrabContext> options)
            : base(options)
        {
        }

        public DbSet<MightyGrab.Models.BaseGrabModel> BaseGrabModel { get; set; }
    }
}
