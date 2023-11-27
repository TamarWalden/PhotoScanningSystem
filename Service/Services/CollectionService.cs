using AutoMapper;
using Common.DTO_s;
using Repository.Entities;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CollectionService:ICollectionService
    {
        private readonly IRepository<Collection> collectionRepository;
        private readonly IMapper mapper;

        public CollectionService(IRepository<Collection> collectionRepository, IMapper mapper)
        {
            this.collectionRepository = collectionRepository;
            this.mapper = mapper;
        }

        public async Task<CollectionDTO> GetCollection(string collectionSymbolization)
        {
            try
            {
                var collection = await collectionRepository.GetByIdAsync(collectionSymbolization);
                return mapper.Map<CollectionDTO>(collection);
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
