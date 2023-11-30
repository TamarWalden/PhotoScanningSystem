using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface ICollectionRepository
    {
        Task<List<Collection>> GetAllAsync();
        Task addImagesToFileAsync(List<Image> images, string collectionSymbolization);
    }
}
