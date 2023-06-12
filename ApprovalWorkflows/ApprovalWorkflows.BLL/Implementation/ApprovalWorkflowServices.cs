using ApprovalWorkflows.BLL.Contract;
using ApprovalWorkflows.BO;
using ApprovalWorkflows.DAL.Contract;

namespace ApprovalWorkflows.BLL.Implementation
{
    public class ApprovalWorkflowServices : IApprovalWorkflowServices
    {
        private IApprovalWorkflowRepository _workflowRepo;

        public ApprovalWorkflowServices(IApprovalWorkflowRepository workflowRepo)
        {
            _workflowRepo = workflowRepo;
        }
        public List<TemplateBO> GetApprovalWorkflow()
        {
            return _workflowRepo.GetAllApprovalWorkflow();
        }
        public TemplateBO UpdateApprovalWorkflow(int id, TemplateBO updateTemplate)
        {
            return _workflowRepo.UpdateApprovalWorkflow(id, updateTemplate);
        }
        public bool DeleteApprovalWorkflow(int id)
        {
            return _workflowRepo.DeleteApprovalWorkflow(id);
        }
        public TemplateBO AddApprovalWorkflow(TemplateBO addTemplate)
        {
            return _workflowRepo.AddApprovalWorkflow(addTemplate);
        }


    }
}
