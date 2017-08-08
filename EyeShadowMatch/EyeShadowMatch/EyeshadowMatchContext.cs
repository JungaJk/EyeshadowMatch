using EyeShadowMatch.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EyeShadowMatch
{
    public class EyeshadowMatchContext :DbContext
    {
        public EyeshadowMatchContext() : base("name=connectionString")
        {
            //Database.SetInitializer(new MeetingRoomInitializer());

           // Database.SetInitializer<SchoolDBContext>(new CreateDatabaseIfNotExists<SchoolDBContext>());

            Database.SetInitializer<EyeshadowMatchContext>(new DropCreateDatabaseIfModelChanges<EyeshadowMatchContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Shade> Shades { get; set; }

        public DbSet<Look> Looks { get; set; }

        public DbSet<ProductShade> ProductShade { get; set; }

        public DbSet<Match> Matches { get; set; }
    }
}