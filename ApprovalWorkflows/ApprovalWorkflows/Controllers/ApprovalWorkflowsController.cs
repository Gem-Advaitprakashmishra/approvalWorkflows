using ApprovalWorkflows.BLL.Contract;
using ApprovalWorkflows.BO.DTOs;
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
        [HttpPost]
        public IActionResult UpdateApprovalWorkflow(int id , UpdateApprovalWorkflowDto updateApprovalWorkflowDto)
        {
            return StatusCode(200,_workflowServices.UpdateApprovalWorkflow(id ,updateApprovalWorkflowDto));
        }
        [HttpDelete]
        public IActionResult DeleteApprovalWorkflow(int id)
        {
            return StatusCode(200,_workflowServices.DeleteApprovalWorkflow(id));
        }
        [HttpPost]
        [Route("AddAll")]
        public IActionResult AddApprovalWorkflow(int id, AddApprovalWorkflowDto addApprovalWorkflowDto)
        {
            return StatusCode(200,_workflowServices.AddApprovalWorkflow(id,addApprovalWorkflowDto));
        }

    }
}
