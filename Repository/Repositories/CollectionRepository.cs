using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CollectionRepository : ICollectionRepository
    {
        private readonly IContext context;
        public CollectionRepository(IContext context)
        {
            this.context = context;
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
        public async Task addImagesToFileAsync(List<Image> images, string collectionSymbolization)
        {
            try
            {
                await context.addImagesToFileAsync(images, collectionSymbolization);
            }
            catch (Exception e) { }
        }
    }
}
