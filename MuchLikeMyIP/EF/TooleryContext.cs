using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuchLikeMyIP.EF
{
    public class TooleryContext : DbContext
    {

        public TooleryContext(DbContextOptions<TooleryContext> options)
            : base(options)
        { }
        public DbSet<Paste> Pastes { get; set; }
    }
}
