using ApprovalWorkflows.BO.DTOs;
using ApprovalWorkflows.BO.Entites;
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

        public List<ApiBusinessObjects> GetAllApprovalWorkflow()
        {
            var query = "Select * from ApprovalWorkflows";
            using (var connection = _context.CreateConnection())
            {
                var people = connection.Query<ApiBusinessObjects>(query);
                return people.ToList();
            }
        }
        public UpdateApprovalWorkflowDto UpdateApprovalWorkflow(int id,UpdateApprovalWorkflowDto updateApprovalWorkflowDto)
        {
            var query = "Update ApprovalWorkflows Set Type =@Type , Name =@Name , Template = @Template where TemplateID =@id";
            {
                var parameters = new DynamicParameters();
                parameters.Add("id", id ,DbType.Int64);
                parameters.Add("Type", updateApprovalWorkflowDto.Type, DbType.String);
                parameters.Add("Name",updateApprovalWorkflowDto.Name,DbType.String);
                parameters.Add("Template", updateApprovalWorkflowDto.Template, DbType.String);
               
                using (var connection = _context.CreateConnection())
                {
                   var value = connection.Execute(query, parameters);
                    if (value >0)
                    {
                        return updateApprovalWorkflowDto;
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
        public AddApprovalWorkflowDto AddApprovalWorkflow(int id, AddApprovalWorkflowDto addApprovalWorkflowDto)
        {
            var query = "Insert into ApprovalWorkflows (TemplateID,Type,Name,Template) values (@id,@Type,@Name,@Template)";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int64);
            parameters.Add("Type", addApprovalWorkflowDto.Type, DbType.String);
            parameters.Add("Name", addApprovalWorkflowDto.Name, DbType.String);
            parameters.Add("Template", addApprovalWorkflowDto.Template, DbType.String);

            using (var connection = _context.CreateConnection())
            {
                var value = connection.Execute(query, parameters);
                if (value > 0)
                {
                    return addApprovalWorkflowDto;
                }
                else
                {
                    return null;
                }
            }


        }
    }

    }

