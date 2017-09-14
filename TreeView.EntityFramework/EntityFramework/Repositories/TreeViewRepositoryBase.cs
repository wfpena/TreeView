using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TreeView.EntityFramework.Repositories
{
    /// <summary>
    /// We declare a base repository class for our application.
    /// It inherits from <see cref="EfRepositoryBase{TDbContext,TEntity,TPrimaryKey}"/>.
    /// We can add here common methods for all our repositories.
    /// </summary>
    public abstract class TreeViewRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TreeViewDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TreeViewRepositoryBase(IDbContextProvider<TreeViewDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }

    /// <summary>
    /// A shortcut of <see cref="TreeViewRepositoryBase{TEntity,TPrimaryKey}"/> for Entities with primary key type <see cref="int"/>.
    /// </summary>
    public abstract class TreeViewRepositoryBase<TEntity> : TreeViewRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TreeViewRepositoryBase(IDbContextProvider<TreeViewDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
