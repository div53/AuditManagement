using AuditSeverity_MicroService.Logger;
using AuditSeverity_MicroService.Repository.IRepository;
using AutoMapper;
using Global_MicroService.Dtos;
using Global_MicroService.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AuditSeverity_MicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditSeverityController : ControllerBase
    {

        private readonly IAuditSeverityRepository _repo;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger; 

        public AuditSeverityController(IAuditSeverityRepository repo, IMapper mapper, ILoggerManager logger)
        {
            _repo = repo;
            _mapper = mapper;
            _logger = logger; 
        }

        /// <summary>
        /// Post The AuditRequestDto and Get AuditResponseDto object in response!
        /// </summary>
        /// <param name="auditRequestDto">AuditRequestDto Object</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AuditSeverity([FromBody] AuditRequestDto auditRequestDto)
        {
            if (auditRequestDto == null)
            {
                return BadRequest(ModelState);
            }

            _logger.LogInformation(auditRequestDto.auditDetail.AuditType.ToString());
            var auditRequestModle = _mapper.Map<AuditRequestModel>(auditRequestDto);

            var auditResponseModel = await _repo.Manipulate(auditRequestModle);

            if (auditResponseModel == null) {
                return StatusCode(500,ModelState);
            }
            else
            {
                AuditResponseDto auditResponseDto = _mapper.Map<AuditResponseDto>(auditResponseModel);
                
                return CreatedAtRoute("GetAuditSeverity", new {auditId = auditResponseModel.AuditId }, auditResponseModel);
            }
        }

        [HttpGet(Name ="GetAuditSeverity")]
        public IActionResult GetAuditSeverity(int auditId) {

            return Ok();
        }
    }
}
