using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        /// <summary>
        /// Uses the base class
        /// </summary>
        /// <param name="options"></param>
        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options)
            : base(options)
        {

        }

        /// <summary>
        /// dbSet is the Restaurants table
        /// </summary>
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
