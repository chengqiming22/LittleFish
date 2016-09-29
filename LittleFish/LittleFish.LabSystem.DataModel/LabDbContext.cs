using LittleFish.LabSystem.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFish.LabSystem.DataModel
{
    public class LabDbContext : DbContext
    {
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Laboratory> Labs { get; set; }
        public LabDbContext()
            : base("connStr")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ResourceCategory>().HasMany(c => c.Resources).WithRequired(r => r.Category).WillCascadeOnDelete();
        }
    }
}
