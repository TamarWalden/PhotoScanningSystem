using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Image
    {
        public string CollectionSymbolization { get; set; }
        public int Id { get; set; }
        public string Path { get; set; }
        public string? Path_xx { get; set; }

        public Image(string collectionSymbolization, int id) 
        {
            this.CollectionSymbolization = collectionSymbolization;
            this.Id = id;
            this.Path = collectionSymbolization+"\\"+id.ToString();
            this.Path_xx = collectionSymbolization + "\\" + id.ToString()+"_xx";
        }  

    }
}
