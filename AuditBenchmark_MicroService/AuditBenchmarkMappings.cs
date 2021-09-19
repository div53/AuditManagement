using AutoMapper;
using Global_MicroService.Dtos;
using Global_MicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchmark_MicroService
{
    public class AuditBenchmarkMappings : Profile
    {
        public AuditBenchmarkMappings()
        {
            CreateMap<AuditBenchmarkModel, AuditBenchmarkDto>().ReverseMap();
        }
    }
}
