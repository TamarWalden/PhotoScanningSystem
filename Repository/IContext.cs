﻿using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IContext
    {
        Task<List<Collection>> LoadCollectionsFromFileAsync();
        Task CreateJsonFileAsync(Image image);
        Task addImagesToFileAsync(List<Image> images, string collectionSymbolization);
    }
}
