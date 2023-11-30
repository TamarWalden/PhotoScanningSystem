using Common.DTO_s;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ICollectionService
    {
        Task<CollectionDTO> GetCollection(string collectionSymbolization);
        Task UploadImages(List<ImageDTO> images);
    }
}
