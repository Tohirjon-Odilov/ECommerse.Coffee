using ECommerse.Coffee.Application.Abstraction.Repsotitories;
using ECommerse.Coffee.Domain.Exceptions;
using ECommerse.Coffee.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ECommerse.Coffee.Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        private readonly CoffeShopDbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(CoffeShopDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> Create(T entity)
        {
            var result = await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<bool> Delete(Expression<Func<T, bool>> expression)
        {
            var result = await _dbSet.FirstOrDefaultAsync(expression);
            if (result == null)
            {
                return false;
            }
            _dbSet.Remove(result);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByAny(Expression<Func<T, bool>> expression)
        {
            try
            {
                var result = await _dbSet.FirstOrDefaultAsync(expression)
                    ?? throw new NotFoundException("Not found");
                return result;
            }
            catch
            {
                throw;
            }
        }

        public async Task<T> Update(T entity)
        {
            var result = _dbSet.Update(entity);
            await _context.SaveChangesAsync();

            return result.Entity;
        }
    }
}
