using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebTest2.Models
{
    public class WebTest2Context : DbContext
    {
        public WebTest2Context (DbContextOptions<WebTest2Context> options)
            : base(options)
        {
        }

        public DbSet<WebTest2.Models.Movie> Movie { get; set; }
    }
}
