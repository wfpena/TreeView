
namespace TreeView.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TreeView.EntityFramework.TreeViewDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TreeView.EntityFramework.TreeViewDbContext context)
        {
            
        }
    }
}
