﻿using Msi.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Msi.Data.Abstractions
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {

        Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);

        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicatebool);

        IQueryable<TEntity> WhereAsReadOnly(Expression<Func<TEntity, bool>> predicate);

        Task<List<TViewModel>> ListAsync<TViewModel>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TViewModel>> selector, CancellationToken cancellationToken = default);

        Task<List<TViewModel>> ListAsyncAsReadOnly<TViewModel>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TViewModel>> selector, CancellationToken cancellationToken = default);

        TEntity Remove(TEntity entity);

        void AttachRange(IEnumerable<TEntity> entities);

        void Attach(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

        Task<long> LongCountAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

        //Task<bool> ExistAsync(long id);

        //bool Exist(long? id);

        Task<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> predicate, bool readOnly = false, CancellationToken cancellationToken = default);

        Task<TEntity> FirstOrDefaultAsyncAsReadOnly(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

        Task<TViewModel> FirstOrDefaultAsync<TViewModel>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TViewModel>> selector, CancellationToken cancellationToken = default);

        Task<TViewModel> FirstOrDefaultAsyncAsReadOnly<TViewModel>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TViewModel>> selector, CancellationToken cancellationToken = default);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        IQueryable<TEntity> AsQueryable();

        IQueryable<TEntity> AsReadOnly();

        Task<TResponse> MatchAsync<TResponse>(ICriteria<TEntity, TResponse> criteria);
    }
}
