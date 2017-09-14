using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Abp.EntityFramework;
using TreeView;
using TreeView.Nodes;

namespace TreeView.EntityFramework.Repositories
{
    public class NodeRepository : TreeViewRepositoryBase<Node, int>, INodeRepository
    {
        public NodeRepository(IDbContextProvider<TreeViewDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        
    }
}
