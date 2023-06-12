using ApprovalWorkflows.BO;


namespace ApprovalWorkflows.DAL.Contract
{

    public interface IApprovalWorkflowRepository
    {
        public List<TemplateBO> GetAllApprovalWorkflow();
        public TemplateBO UpdateApprovalWorkflow(int id , TemplateBO updateTemplate);
        public bool DeleteApprovalWorkflow(int id);
        public TemplateBO AddApprovalWorkflow(TemplateBO addTemplate);

    }

}
