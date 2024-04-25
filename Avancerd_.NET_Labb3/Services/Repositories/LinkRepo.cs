using Avancerd_.NET_Labb3.Data;
using Avancerd_.NET_Labb3.Services.Interfaces;
using Labb3_Models_;
using Microsoft.EntityFrameworkCore;

namespace Avancerd_.NET_Labb3.Services.Repositories
{
    public class LinkRepo : Labb3Interface<Link>
    {
        private AppDbContext _appContext;

        public LinkRepo(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<Link> Add(Link newEntity)
        {
            var result = await _appContext.Links.AddAsync(newEntity);
            await _appContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Link> Delete(int id)
        {
            var result = await _appContext.Links.FirstOrDefaultAsync
                (h => h.LinkID == id);
            if (result != null)
            {
                _appContext.Links.Remove(result);
                await _appContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Link>> GetAll()
        {
            return await _appContext.Links.Include(l => l.Hobby).ToListAsync();
        }

        public async Task<Link> GetSingle(int id)
        {
            return await _appContext.Links.
                FirstOrDefaultAsync(l => l.LinkID == id);
        }

        public async Task<Link> Update(Link entity)
        {
            var result = await _appContext.Links.
               FirstOrDefaultAsync(l => l.LinkID == entity.LinkID);
            if (result != null)
            {
                result.URL = entity.URL;
                
                await _appContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
