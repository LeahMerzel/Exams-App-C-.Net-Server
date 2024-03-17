using Exams_App_C__.Net_Server.Data.DB;
using Exams_App_C__.Net_Server.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Exams_App_C__.Net_Server.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ExamsDbContext dbContext;

        public GenericRepository(ExamsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //GET
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetAsync(string? id)
        {
            if (id == null)
            {
                return null;
            }

            return await dbContext.Set<T>().FindAsync(id);
        }

        // POST
        public virtual async Task<T> AddAsync(T entity)
        {
            await dbContext.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        // PUT
        public virtual async Task<bool> UpdateAsync(T entity)
        {
            dbContext.Update(entity);
            await dbContext.SaveChangesAsync();
            return true;
        }

        // DELETE {Id}
        public virtual async Task DeleteAsync(string? id)
        {
            var entity = await GetAsync(id);
            dbContext.Set<T>().Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public string GetEntityId(T entity)
        {
            var idProperty = entity.GetType().GetProperty("Id");

            if (idProperty == null)
            {
                throw new InvalidOperationException($"Type {entity.GetType().Name} does not have a property named 'Id'.");
            }

            var idValue = idProperty.GetValue(entity);

            if (idValue is string guidValue)
            {
                return guidValue;
            }

            throw new InvalidOperationException($"Invalid or missing 'Id' property value. Actual type: {idValue?.GetType().Name}");
        }

    }
}
