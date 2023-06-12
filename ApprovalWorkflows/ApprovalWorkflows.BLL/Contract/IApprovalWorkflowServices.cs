using ApprovalWorkflows.BO;

namespace ApprovalWorkflows.BLL.Contract
{
    public interface IApprovalWorkflowServices
    {
        public List<TemplateBO> GetApprovalWorkflow();
        public TemplateBO UpdateApprovalWorkflow(int id, TemplateBO updateTemplate);
        public bool DeleteApprovalWorkflow(int id);
        public TemplateBO AddApprovalWorkflow(TemplateBO addTemplate);

    }
}
