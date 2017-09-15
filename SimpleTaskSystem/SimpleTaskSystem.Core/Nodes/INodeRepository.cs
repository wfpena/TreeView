using System.Collections.Generic;
using Abp.Domain.Repositories;

namespace SimpleTaskSystem.Nodes
{
    public interface INodeRepository : IRepository<Node,int>
    {
       
    }
}
