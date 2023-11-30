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
        private readonly ICollectionRepository collectionRepository;
        private readonly IImageRepository imageRepository;
        private readonly IMapper mapper;

        public CollectionService(ICollectionRepository collectionRepository, IImageRepository imageRepository, IMapper mapper)
        {
            this.collectionRepository = collectionRepository;
            this.imageRepository = imageRepository;
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

        private async Task CreateDocumentationFile(Image image)
        {
            try
            {
                await imageRepository.CreateJsonFileAsync(image);
            }
            catch (Exception ex) { }

        }

        private async Task addImagesToFileAsync(List<Image> images)
        {
            try
            {
                await collectionRepository.addImagesToFileAsync(images, images[0].CollectionSymbolization);
            }
            catch(Exception ex) { }
        }

        public async Task UploadImages(List<ImageDTO> images)
        {
            try
            {
                foreach (var image in images)
                {
                    if (image.IsSaved == false)
                    {
                        var imageEntity=mapper.Map<Image>(image);
                        //await imageRepository.UploadImage(imageEntity);
                        await CreateDocumentationFile(imageEntity);
                    }
                }
                var imagesEntities = mapper.Map<List<Image>>(images);
                addImagesToFileAsync(imagesEntities);
            }
            catch (Exception ex) { }
        }
    }
}
