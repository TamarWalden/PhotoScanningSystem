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
        private readonly IContext context;
        public CollectionRepository(IContext context)
        {
            this.context = context;
        }
        public Task<Collection> AddAsync(Collection entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Collection>> GetAllAsync()
        {
            try
            {
                return await context.LoadCollectionsFromFileAsync();
            }
            catch (Exception e)
            {
                return new List<Collection>();
            }
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
