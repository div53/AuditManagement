using Global_MicroService.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Global_MicroService.Models
{
    public class AuditBenchmarkModel
    {
        [Required]
        AuditTypeEnum AuditType { get; set; }

        [Required]
        int benchmark { get; set; }
    }
}
