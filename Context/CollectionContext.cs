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
        string filePath = @"CollectionsFile.json";
        

        public CollectionContext()
        {
        }

        public async Task<List<Collection>> LoadCollectionsFromFileAsync()
        {
            try
            {
                string json = await File.ReadAllTextAsync(filePath);
                var _collections = JsonConvert.DeserializeObject<List<Collection>>(json);
                return _collections;
            }
            catch (Exception ex)
            {
                return new List<Collection>();
            }
        }
    }
}
