using ApprovalWorkflows.BO.DTOs;
using ApprovalWorkflows.BO.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovalWorkflows.BLL.Contract
{
    public interface IApprovalWorkflowServices
    {
        public List<ApiBusinessObjects> GetApprovalWorkflow();
        public UpdateApprovalWorkflowDto UpdateApprovalWorkflow(int id, UpdateApprovalWorkflowDto updateApprovalWorkflowDto);
        public bool DeleteApprovalWorkflow(int id);
        public AddApprovalWorkflowDto AddApprovalWorkflow( AddApprovalWorkflowDto addApprovalWorkflowDto);

    }
}
