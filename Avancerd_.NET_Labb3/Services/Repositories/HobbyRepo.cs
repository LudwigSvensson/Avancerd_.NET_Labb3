using Avancerd_.NET_Labb3.Data;
using Avancerd_.NET_Labb3.Services.Interfaces;
using Labb3_Models_;
using Microsoft.EntityFrameworkCore;
using System;

namespace Avancerd_.NET_Labb3.Services.Repositories
{
    public class HobbyRepo : Labb3Interface<Hobby>
    {
        private AppDbContext _appContext;

        public HobbyRepo(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<Hobby> Add(Hobby newEntity)
        {
            var result = await _appContext.Hobbies.AddAsync(newEntity);
            await _appContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Hobby> Delete(int id)
        {
            var result = await _appContext.Hobbies.FirstOrDefaultAsync
                (h => h.HobbyID == id);
            if (result != null)
            {
                _appContext.Hobbies.Remove(result);
                await _appContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Hobby>> GetAll()
        {
            return await _appContext.Hobbies.Include(h => h.Links).ToListAsync();
        }

        public async Task<Hobby> GetSingle(int id)
        {
            return await _appContext.Hobbies.Include(h => h.Links).Include(h => h.Person).
                FirstOrDefaultAsync(p => p.HobbyID == id);
        }

        public async Task<Hobby> Update(Hobby entity)
        {
            var result = await _appContext.Hobbies.
                FirstOrDefaultAsync(h => h.HobbyID == entity.HobbyID);
            if (result != null)
            {
                result.Person.PersonID = entity.PersonID;
                result.HobbyTitle = entity.HobbyTitle;
                result.HobbyDescription = entity.HobbyDescription;

                await _appContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
