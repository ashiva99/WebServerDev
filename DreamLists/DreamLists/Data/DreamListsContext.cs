using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DreamLists.Models;

namespace DreamLists.Data
{
    public class DreamListsContext : DbContext
    {
        public DreamListsContext (DbContextOptions<DreamListsContext> options)
            : base(options)
        {
        }

        public DbSet<DreamLists.Models.DreamList> DreamList { get; set; } = default!;
    }
}
