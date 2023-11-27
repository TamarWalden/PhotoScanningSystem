using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ImageRepository : IRepository<Image>
    {
        public Task<Image> AddAsync(Image entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Image>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Image> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Image> UpdateAsync(Image entity)
        {
            throw new NotImplementedException();
        }
    }
}
