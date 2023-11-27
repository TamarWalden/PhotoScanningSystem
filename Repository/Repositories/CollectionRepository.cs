using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CollectionRepository : IRepository<Collection>
    {
        public Task<Collection> AddAsync(Collection entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Collection>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Collection> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Collection> UpdateAsync(Collection entity)
        {
            throw new NotImplementedException();
        }
    }
}
