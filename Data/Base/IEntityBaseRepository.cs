using System.Collections.Generic;
using System.Threading.Tasks;

namespace new_testapp.Data.Base
{

    //where keyword is used in combination with the generic class to add some constraints.
    public interface IEntityBaseRepository<T> where T : class, IEntityBase,new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);

        Task AddAsync(T entity);

        Task UpdateAsync(int id, T entity);

        Task DeleteAsync(int id);
    }
}
