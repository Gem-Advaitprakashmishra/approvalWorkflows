using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovalWorkflows.BO.DTOs
{
    public class AddApprovalWorkflowDto
    {
        public int TemplateID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }
    }
}
