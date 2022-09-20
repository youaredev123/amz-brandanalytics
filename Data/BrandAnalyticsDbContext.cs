using brandanalytics.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brandanalytics.Data
{
    public class BrandAnalyticsDbContext : DbContext
    {
        public virtual DbSet<SearchTerm> SearchTerms { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=BrandAnalytics;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
