using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Collection
    {
        public int CollectionSymbolization { get; set; }
            
        public string Title { get; set; }
        public string ItemId { get; set; }
        public List<Image> Images { get; set; }
    }
}
