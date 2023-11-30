using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Collection
    {
        public Collection() { }
        public Collection(string CollectionSymbolization, string Title, string ItemId, List<Image> Images) 
        {
            this.CollectionSymbolization=CollectionSymbolization;
            this.Title=Title;
            this.ItemId=ItemId;
            this.Images=Images;
        }
        public string CollectionSymbolization { get; set; }      
        public string Title { get; set; }
        public string ItemId { get; set; }
        public List<Image> Images { get; set; }
    }
}
