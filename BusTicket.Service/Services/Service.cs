using BusTicket.Core.Repositories;
using BusTicket.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Service.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;
        
        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
          return await _repository.FirstOrDefaultAsync(predicate);
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<List<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate)
        {
           return await _repository.ListAsync(predicate);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
        }

        public TEntity Update(TEntity entity)
        {
           TEntity UpdateEntity= _repository.Update(entity);
            return (UpdateEntity);
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {

           return await _repository.GetAllAsync();

        }
    }
}
