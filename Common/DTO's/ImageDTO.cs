using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO_s
{
    public class ImageDTO
    {
        public string CollectionSymbolization {  get; set; }
        public int Id { get; set; }
        public string Path { get; set; }
        public string? Path_xx { get; set; }
        public Boolean IsSaved { get;set; }
    }
}
