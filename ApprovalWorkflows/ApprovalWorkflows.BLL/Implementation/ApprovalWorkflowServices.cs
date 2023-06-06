using ApprovalWorkflows.BLL.Contract;
using ApprovalWorkflows.BO.DTOs;
using ApprovalWorkflows.BO.Entites;
using ApprovalWorkflows.DAL.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovalWorkflows.BLL.Implementation
{
    public class ApprovalWorkflowServices : IApprovalWorkflowServices
    {
        private IApprovalWorkflowRepository _WorkflowRepo;

        public ApprovalWorkflowServices(IApprovalWorkflowRepository WorkflowRepo)
        {
            _WorkflowRepo = WorkflowRepo;
        }
        public List<ApiBusinessObjects> GetApprovalWorkflow()
        {
            return _WorkflowRepo.GetAllApprovalWorkflow();
        }
        public UpdateApprovalWorkflowDto UpdateApprovalWorkflow(int id, UpdateApprovalWorkflowDto updateApprovalWorkflowDto)
        {
            return _WorkflowRepo.UpdateApprovalWorkflow(id, updateApprovalWorkflowDto);
        }
        public bool DeleteApprovalWorkflow(int id)
        {
            return _WorkflowRepo.DeleteApprovalWorkflow(id);
        }
        public AddApprovalWorkflowDto AddApprovalWorkflow(AddApprovalWorkflowDto addApprovalWorkflowDto)
        {
            return _WorkflowRepo.AddApprovalWorkflow(addApprovalWorkflowDto);
        }


    }
}
