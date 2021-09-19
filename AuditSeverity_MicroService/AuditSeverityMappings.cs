using AutoMapper;
using Global_MicroService.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditSeverity_MicroService
{
    public class AuditSeverityMappings : Profile
    {
        public AuditSeverityMappings()
        {
            CreateMap<AuditRequestModel, AuditRequestDto>().ReverseMap();
            CreateMap<AuditDetailModel, AuditDetailDto>().ReverseMap();
            CreateMap<AuditAnswerModel, AuditAnswerDto>().ReverseMap();
            CreateMap<AuditResponseModel, AuditResponseDto>().ReverseMap();
        }
    }
}
