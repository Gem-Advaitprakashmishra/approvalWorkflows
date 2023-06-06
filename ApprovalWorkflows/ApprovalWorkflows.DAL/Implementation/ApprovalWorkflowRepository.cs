using ApprovalWorkflows.BO.Entites;
using ApprovalWorkflows.DAL.Contract;
using ApprovalWorkflows.DAL.Data;
using Dapper;

namespace ApprovalWorkflows.DAL.Implementation
{
    public class ApprovalWorkflowRepository : IApprovalWorkflowRepository
    {
        private readonly DapperContext _context;
        public ApprovalWorkflowRepository(DapperContext context)
        {
            _context = context;
        }

        public List<ApiBusinessObjects> GetAllApprovalWorkflow()
        {
            var query = "Select * from ApprovalWorkflows";
            using (var connection = _context.CreateConnection())
            {
                var people = connection.Query<ApiBusinessObjects>(query);
                return people.ToList();
            }
        }
    }
}
