using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanusYazilim.Entities;
using FanusYazilim.Entities.Hash_SHA1;
using FanusYazilim.DataAccessLayer.DatabaseInitıalizer;

namespace FanusYazilim.DataAccessLayer.EntityFramework
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext():base("GlobalHikayeMatik")
        {
            Database.SetInitializer(new Initializer());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Content> Contents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
        }
    }
}
