using GolpoPuri.Library;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace GolpoPuri.DAL
{
    public class StoryContext : DbContext
    {
        public StoryContext() : base("StoryContext")
        {
            Database.SetInitializer<StoryContext>(new DropCreateDatabaseIfModelChanges<StoryContext>());
        }

        public DbSet<Story> Story { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Developer> Developer { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}