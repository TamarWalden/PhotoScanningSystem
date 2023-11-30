using AutoMapper;
using Common.DTO_s;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<CollectionDTO, Collection>().ReverseMap();
            CreateMap<Image, ImageDTO>().ForMember(dast => dast.IsSaved, opt => opt.Ignore());
            CreateMap<ImageDTO, Image>();
        }
    }
}
