using AutoMapper;
using Global_MicroService.Dtos;
using Global_MicroService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditChecklist_MicroService
{
    public class AuditChecklistMappings : Profile
    {

        public AuditChecklistMappings()
        {
            CreateMap<AuditQuestionModel, AuditQuestionDto>().ReverseMap();
        }
    }
}
