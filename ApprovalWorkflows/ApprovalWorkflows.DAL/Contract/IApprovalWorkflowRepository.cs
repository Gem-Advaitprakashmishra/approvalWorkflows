using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprovalWorkflows.BO.DTOs;
using ApprovalWorkflows.BO.Entites;


namespace ApprovalWorkflows.DAL.Contract
{
   
    public interface IApprovalWorkflowRepository
    {
        public List<ApiBusinessObjects> GetAllApprovalWorkflow();
        public UpdateApprovalWorkflowDto UpdateApprovalWorkflow(int id , UpdateApprovalWorkflowDto updateApprovalWorkflowDto);
        public bool DeleteApprovalWorkflow(int id);
        public AddApprovalWorkflowDto AddApprovalWorkflow(int id, AddApprovalWorkflowDto addApprovalWorkflowDto);

    }

}
