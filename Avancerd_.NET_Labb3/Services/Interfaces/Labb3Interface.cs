using Labb3_Models_;
using Microsoft.EntityFrameworkCore.Design.Internal;

namespace Avancerd_.NET_Labb3.Services.Interfaces
{
    public interface Labb3Interface<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetSingle(int id);
        Task<T> Add(T newEntity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
