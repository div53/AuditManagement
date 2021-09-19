using Global_MicroService.Dtos;
using Global_MicroService.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchmark_MicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditBenchmarkController : ControllerBase
    {

        [HttpGet(Name = "GetAuditBenchmark")]
        public IActionResult GetAuditBenchmarks()
        {
            //* statically writing.
            var auditBenchmarkDto = new List<AuditBenchmarkDto>() {
                new AuditBenchmarkDto() {
                    AuditType = Global_MicroService.Enums.AuditTypeEnum.Internal ,
                    Benchmark = 3,
                },
                new AuditBenchmarkDto() {
                    AuditType = Global_MicroService.Enums.AuditTypeEnum.SOX ,
                    Benchmark = 1,
                },
             };

            return Ok(auditBenchmarkDto);
        }

        [HttpGet("{auditType:int}",Name = "GetTypeBenchmark")]
        public IActionResult GetTypeBenchmark(AuditTypeEnum auditType)
        {
            
            if(auditType == AuditTypeEnum.Internal)
            {
                var auditBenchmark = new AuditBenchmarkDto()
                {
                    AuditType = Global_MicroService.Enums.AuditTypeEnum.Internal,
                    Benchmark = 3,
                };
                return Ok(auditBenchmark);
            }
            else
            {
                var auditBenchmark = new AuditBenchmarkDto()
                {
                    AuditType = Global_MicroService.Enums.AuditTypeEnum.SOX,
                    Benchmark = 1,
                };
                return Ok(auditBenchmark);
            }
        }


    }
}
