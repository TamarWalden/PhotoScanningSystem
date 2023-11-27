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

        public List<Image> Pictures { get; set; }
        public List<Collection> Collections {  get; set; }

        
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
