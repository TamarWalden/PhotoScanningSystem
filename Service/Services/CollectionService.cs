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
                var collections= await collectionRepository.GetAllAsync();
                List<CollectionDTO> collectionsDTO= mapper.Map<List<CollectionDTO>>(collections);
                return collectionsDTO.FirstOrDefault(c => c.CollectionSymbolization == collectionSymbolization);
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
