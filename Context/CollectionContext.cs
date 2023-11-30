using Newtonsoft.Json;
using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonContext
{
    public class CollectionContext:IContext
    {
        string collectionsfilePath = @"C:\Users\User\Desktop\PhotoScanningSystem\Context\CollectionsFile.json";
        string photoDocumentationFilesPath= @"C:\Users\User\Desktop\PhotoScanningSystem\Context\PhotoDocumentationFiles\";
        public async Task<List<Collection>> LoadCollectionsFromFileAsync()
        {
            try
            {
                var _collections = await deserializeCollectionsFileAsync();
                foreach (var collection in _collections)
                {
                    //TODO:in the internial
                    string collectionFolderPath = Path.Combine(photoDocumentationFilesPath, collection.CollectionSymbolization);
                    //if (!Directory.Exists(collectionFolderPath))
                    Directory.CreateDirectory(collectionFolderPath);
                }
                return _collections;
            }
            catch (Exception ex)
            {
                return new List<Collection>();
            }
        }

        public async Task addImagesToFileAsync(List<Image> images, string collectionSymbolization)
        {
            try
            {
                var _collections = await deserializeCollectionsFileAsync();
                Collection? targetCollection = _collections.FirstOrDefault(c => c.CollectionSymbolization == collectionSymbolization);

                if (targetCollection != null)
                {
                    targetCollection.Images = images;
                    string updatedFileContent = JsonConvert.SerializeObject(_collections);
                    await File.WriteAllTextAsync(collectionsfilePath, updatedFileContent);
                }
                else
                {
                    // Collection not found, handle the error accordingly (e.g., throw an exception)
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error, throw a custom exception, etc.)
            }
        }

        public async Task CreateJsonFileAsync(Image image)
        {
            try
            {
                string json = JsonConvert.SerializeObject(image);
                photoDocumentationFilesPath += image.CollectionSymbolization + "\\";
                string fileName = image.Id.ToString() + ".json";
                //TODO: do in DI
                using (StreamWriter writer = new StreamWriter(photoDocumentationFilesPath + fileName))
                {
                    await writer.WriteAsync(json);
                }
            }
            catch(Exception ex) {}
        }

        private async Task<List<Collection>> deserializeCollectionsFileAsync()
        {
            try
            {
                string fileContent = await File.ReadAllTextAsync(collectionsfilePath);
                var collections = JsonConvert.DeserializeObject<List<Collection>>(fileContent);
                return collections;
            }
            catch 
            { 
                return new List<Collection> { };
            }
        }
    }
}
