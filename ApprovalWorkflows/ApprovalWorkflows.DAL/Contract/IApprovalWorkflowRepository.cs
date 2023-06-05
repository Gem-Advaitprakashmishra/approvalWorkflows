using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprovalWorkflows.BO.Entites;

namespace ApprovalWorkflows.DAL.Contract
{
    public interface IApprovalWorkflowRepository
    {
        public List<ApiBusinessObjects> GetAllApprovalWorkflow();
    }
}
