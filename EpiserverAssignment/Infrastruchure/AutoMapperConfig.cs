using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using EpiserverAssignment.Models;

namespace EpiserverAssignment.Infrastruchure
{
    public class AutoMapperConfig
    {
        public static IMapper CreateIMapper()
        {
            var mapperConfiguration = new MapperConfiguration(cfg => {
                cfg.CreateMap<ContentModel, ContentModelDTO>();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}