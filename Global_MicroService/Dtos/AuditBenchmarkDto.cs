using Global_MicroService.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Global_MicroService.Dtos
{
    public class AuditBenchmarkDto
    {
       
        public AuditTypeEnum AuditType { get; set; }
        public int Benchmark { get; set; }
    }
}
