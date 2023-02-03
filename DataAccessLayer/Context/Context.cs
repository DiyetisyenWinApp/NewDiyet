using Enitities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class Context : DbContext
    {
        public Context() : base("DiyetDBContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<FoodInfo> FoodInfos { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<BodyAnalysis> BodyAnalyses { get; set; }
    }
}
