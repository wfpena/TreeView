using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;
using SimpleTaskSystem.Nodes;

namespace SimpleTaskSystem.EntityFramework
{
    public class SimpleTaskSystemDbContext : AbpDbContext
    {
        public virtual IDbSet<Node> Nodes { get; set; }

        public SimpleTaskSystemDbContext()
            : base("Default")
        {

        }

        public SimpleTaskSystemDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            
        }

        //This constructor is used in tests
        public SimpleTaskSystemDbContext(DbConnection connection)
            : base(connection, true)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Node>()
                    .HasOptional(i => i.ParentNode)
                    .WithMany(i => i.ChildNodes)
                    .HasForeignKey(i => i.ParentId);         
        }
    }
}
