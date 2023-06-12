using ApprovalWorkflows.BO;
using ApprovalWorkflows.DAL.Contract;
using ApprovalWorkflows.DAL.Data;
using Dapper;
using System.Data;

namespace ApprovalWorkflows.DAL.Implementation
{
    public class ApprovalWorkflowRepository : IApprovalWorkflowRepository
    {
        private readonly DapperContext _context;
        public ApprovalWorkflowRepository(DapperContext context)
        {
            _context = context;
        }

        public List<TemplateBO> GetAllApprovalWorkflow()
        {
            var query = "Select * from ApprovalWorkflows";
            using (var connection = _context.CreateConnection())
            {
                var people = connection.Query<TemplateBO>(query);
                return people.ToList();
            }
        }
        public TemplateBO UpdateApprovalWorkflow(int id, TemplateBO updateTemplate)
        {
            var query = "Update ApprovalWorkflows Set Type =@Type , Name =@Name , Template = @Template where TemplateID =@id";
            {
                var parameters = new DynamicParameters();
                parameters.Add("id", id ,DbType.Int64);
                parameters.Add("Type", updateTemplate.Type, DbType.String);
                parameters.Add("Name", updateTemplate.Name,DbType.String);
                parameters.Add("Template", updateTemplate.Template, DbType.String);
               
                using (var connection = _context.CreateConnection())
                {
                   var value = connection.Execute(query, parameters);
                    if (value >0)
                    {
                        return updateTemplate;
                    }
                    else
                    {
                        return null;
                    }
                }


            }
        }
        public bool DeleteApprovalWorkflow(int id)
        {
            var query = "Delete from ApprovalWorkflows where TemplateID =@id";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.Execute(query, new { id });
                if (value==0)
                {
                    return false;

                }
                else
                {
                    return true;
                }
            }
        }
        public TemplateBO AddApprovalWorkflow(TemplateBO addTemplate)
        {
            var query = "Insert into ApprovalWorkflows (Type,Name,Template) values (@Type,@Name,@Template)";
            var parameters = new DynamicParameters();
            parameters.Add("Type", addTemplate.Type, DbType.String);
            parameters.Add("Name", addTemplate.Name, DbType.String);
            parameters.Add("Template", addTemplate.Template, DbType.String);

            using (var connection = _context.CreateConnection())
            {
                var value = connection.Execute(query, parameters);
                if (value > 0)
                {
                    return addTemplate;
                }
                else
                {
                    return null;
                }
            }
        }
    }

}

