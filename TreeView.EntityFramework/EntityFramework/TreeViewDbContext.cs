using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;
using TreeView.Nodes;

namespace TreeView.EntityFramework
{
    public class TreeViewDbContext : AbpDbContext
    {
        public virtual IDbSet<Node> Nodes { get; set; }

        public TreeViewDbContext()
            : base("Default")
        {

        }

        public TreeViewDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            
        }

        //This constructor is used in tests
        public TreeViewDbContext(DbConnection connection)
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
