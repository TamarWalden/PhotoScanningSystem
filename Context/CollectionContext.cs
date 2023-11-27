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
        private List<Image> images = new List<Image>();

        public List<Image> Images
        {
            get { return images; }
            set { images = value; }
        }

        public List<Collection> Collections {  get; set; }    
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
