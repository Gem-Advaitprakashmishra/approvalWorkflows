using ApprovalWorkflows.BLL.Contract;
using Microsoft.AspNetCore.Http;
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
    }
}
