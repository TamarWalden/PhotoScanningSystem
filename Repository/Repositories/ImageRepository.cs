using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly IContext context;
        public ImageRepository(IContext context)
        {
            this.context = context;
        }
        public async Task CreateJsonFileAsync(Image image)
        {
            try
            {
                await context.CreateJsonFileAsync(image);
                //TODO: check if create succese
            }
            catch (Exception ex) {
                
            }
        }

        public Task UploadImage(Image image)
        {
            //TODO: upload image
            throw new NotImplementedException();
        }
    }
}
