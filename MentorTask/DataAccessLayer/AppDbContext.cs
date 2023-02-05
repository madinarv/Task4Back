using MentorTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics.Metrics;

namespace MentorTask.DataAccessLayer
{
    public class AppDbContext :DbContext
    {
      

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

       
        public DbSet<About> Abouts { get; set; }
        public DbSet<Trainers> Trainers { get; set; }
        public DbSet<Pricings> Pricings { get; set; }


    }
}
