
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IImageRepository
    {
        Task CreateJsonFileAsync(Image image);
        Task UploadImage(Image image);
    }
}
