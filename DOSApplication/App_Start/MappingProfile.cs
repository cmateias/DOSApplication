using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSApplication.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Models.DistanceResponse.Response, Dtl.DistanceMatrix>();
            });

            IMapper mapper = config.CreateMapper();
        }        
    }
}