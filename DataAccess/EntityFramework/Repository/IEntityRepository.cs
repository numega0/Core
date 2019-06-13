using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entity;

namespace Core.DataAccess.EntityFramework.Repository
{
    public interface IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, string includes = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includeExpressions);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }

}
