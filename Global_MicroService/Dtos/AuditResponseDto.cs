using Global_MicroService.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Global_MicroService.Dtos
{
    public class AuditResponseDto
    {

        public int AuditId { get; set; }

        public AuditResultEnum AuditExecutionStatus { get; set; }

        public string RemedialActionDuration { get; set; }

    }
}
