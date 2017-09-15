using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Abp.EntityFramework;
using SimpleTaskSystem;
using SimpleTaskSystem.Nodes;

namespace SimpleTaskSystem.EntityFramework.Repositories
{
    public class NodeRepository : SimpleTaskSystemRepositoryBase<Node, int>, INodeRepository
    {
        public NodeRepository(IDbContextProvider<SimpleTaskSystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        
    }
}
