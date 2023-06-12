using ApprovalWorkflows.BLL.Contract;
using ApprovalWorkflows.BO;
using Microsoft.AspNetCore.Mvc;

namespace ApprovalWorkflows.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApprovalWorkflowsController : ControllerBase
    {
        private IApprovalWorkflowServices _workflowServices;

        public ApprovalWorkflowsController(IApprovalWorkflowServices workflowServices)
        {
            _workflowServices = workflowServices;
        }

        [HttpGet]
        public IActionResult GetAllApprovalWorkflow()
        {
            return StatusCode(200, _workflowServices.GetApprovalWorkflow());
        }
        [HttpPost]
        public IActionResult UpdateApprovalWorkflow(int id , TemplateBO updateApprovalWorkflowDto)
        {
            return StatusCode(200,_workflowServices.UpdateApprovalWorkflow(id ,updateApprovalWorkflowDto));
        }
        [HttpDelete]
        public IActionResult DeleteApprovalWorkflow(int id)
        {
            return StatusCode(200,_workflowServices.DeleteApprovalWorkflow(id));
        }
        [HttpPost]
        [Route("AddWorkflowDetails")]
        public IActionResult AddApprovalWorkflow(TemplateBO addApprovalWorkflowDto)
        {
            return StatusCode(200,_workflowServices.AddApprovalWorkflow(addApprovalWorkflowDto));
        }

    }
}
