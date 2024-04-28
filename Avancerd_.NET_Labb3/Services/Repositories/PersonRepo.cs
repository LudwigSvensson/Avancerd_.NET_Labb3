using Avancerd_.NET_Labb3.Data;
using Avancerd_.NET_Labb3.Services.Interfaces;
using Labb3_Models_;
using Microsoft.EntityFrameworkCore;
using System;

namespace Avancerd_.NET_Labb3.Services.Repositories
{
    public class PersonRepo : Labb3Interface<Person>
    {
        private AppDbContext _appContext;

        public PersonRepo(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<Person> Add(Person newEntity)
        {
            var result = await _appContext.Persons.AddAsync(newEntity);
            await _appContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Person> Delete(int id)
        {
            var result = await _appContext.Persons.FirstOrDefaultAsync
                (h => h.PersonID == id);
            if (result != null)
            {
                _appContext.Persons.Remove(result);
                await _appContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            //return await _appContext.Persons.ToListAsync(); 
            
            var some = await _appContext.Persons
                .Include(p => p.Hobbies)
                .ThenInclude(p => p.Links)
                .Include(p => p.Links)
                .ToListAsync();
            return some;
        }

        public async Task<Person> GetSingle(int id)
        {
            return await _appContext.Persons.Include(p =>p.Hobbies).Include(p => p.Links).
                FirstOrDefaultAsync(p => p.PersonID == id);
        }

        public async Task<Person> Update(Person entity)
        {
            var result = await _appContext.Persons.
               FirstOrDefaultAsync(p => p.PersonID == entity.PersonID);
            if (result != null)
            {
                result = entity;
                await _appContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
