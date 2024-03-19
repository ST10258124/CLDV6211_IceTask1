using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CLDV6211_IceTask.Models;

namespace CLDV6211_IceTask.Data
{
    public class CLDV6211_IceTaskContext : DbContext
    {
        public CLDV6211_IceTaskContext (DbContextOptions<CLDV6211_IceTaskContext> options)
            : base(options)
        {
        }

        public DbSet<CLDV6211_IceTask.Models.Music> Music { get; set; } = default!;
    }
}
