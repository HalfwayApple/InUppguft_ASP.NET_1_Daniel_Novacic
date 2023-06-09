﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApi.Contexts;

namespace WebApi.Repos
{
    public abstract class BaseRepository<TEntity, TContext> where TEntity : class where TContext : DbContext
    {
        public readonly TContext _context;

        public BaseRepository(TContext context)
        {
            _context = context;
        }


        public virtual async Task<TEntity> AddAsync(TEntity entity)
		{
            _context.Set<TEntity>().Add(entity);
			await _context.SaveChangesAsync();

			return entity;
		}

		public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
		{
			return await _context.Set<TEntity>().ToListAsync();
		}

		public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
		{
			var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
			if (entity != null)
				return entity;

			return null!;
		}
	}
}
