using AuditChecklist_MicroService.Repository.IRepository;
using AutoMapper;
using Global_MicroService.Dtos;
using Global_MicroService.Enums;
using Global_MicroService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AuditChecklist_MicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditChecklistController : ControllerBase
    {

        private readonly IAuditChecklistRepository _repo;
        private readonly IMapper _mapper;

        public AuditChecklistController(IAuditChecklistRepository repo, IMapper mapper) 
        {
            _repo = repo;
            _mapper = mapper;
        }

        
        [HttpGet( Name = "Questions")]
        public IActionResult GetQuestions()
        {
            var objList =  _repo.GetQuestions();
            if (objList == null)
            {
                return NotFound();
            }

            var objDto = new List<AuditQuestionDto>();

            foreach (var obj in objList)

            {
                var x = _mapper.Map<AuditQuestionDto>(obj);

                objDto.Add(x);
            }
            return Ok(objDto);
        }

        [HttpGet("{auditType:int}" , Name = "TypeQuestions")]
        public IActionResult GetAuditTypeQuestions(AuditTypeEnum auditType)
        {
            var objList = _repo.GetSpecificTypeQuestions(auditType);
            if (objList == null)
            {
                return NotFound();
            }

            var objDto = new List<AuditQuestionDto>();

            foreach (var obj in objList)

            {
                var x = _mapper.Map<AuditQuestionDto>(obj);

                objDto.Add(x);
            }
            return Ok(objDto);

        }
    }
}
