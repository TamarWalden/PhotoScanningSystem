using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CollectionService
    {
        private readonly IRepository<Collection> collectionRepository;
        public CollectionService(IRepository<Collection> collectionRepository)
        {
            this.collectionRepository = collectionRepository;
        }

        public async Task<Collection> GetCollection(int collectionSymbolization)
        {
            try
            {
                return await collectionRepository.GetByIdAsync(collectionSymbolization);
            }
            catch (Exception ex)
            {
                throw new Exception("failed to get collection");
            }
        }

        public async Task CreateDocumentationFile()
        {

        }

        public async Task UploadImage()
        {

        }
    }
}
