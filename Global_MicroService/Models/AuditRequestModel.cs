using Global_MicroService.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Global_MicroService.Dtos
{
    public class AuditRequestModel
    {
        public string ProjectName { get; set; }

        public string ProjectManagerName { get; set; }

        public string ApplicationOwnerName { get; set; }

        public AuditDetailDto  auditDetail{get; set;}

    }

    public class AuditDetailModel
    {
        public AuditTypeEnum AuditType { get; set; }

        public DateTime AuditDate { get; set; }

        public List<AuditAnswerDto> responses { get; set; }


    }


    public class AuditAnswerModel
    {
        public int QuestionId { get; set; }

        public bool Answer { get; set; }
    }

}
