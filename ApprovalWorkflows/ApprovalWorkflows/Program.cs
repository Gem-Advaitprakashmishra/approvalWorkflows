using ApprovalWorkflows.BLL.Contract;
using ApprovalWorkflows.BLL.Implementation;
using ApprovalWorkflows.DAL.Contract;
using ApprovalWorkflows.DAL.Data;
using ApprovalWorkflows.DAL.Implementation;
using System.ComponentModel.Design;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<DapperContext>();
builder.Services.AddScoped<IApprovalWorkflowRepository, ApprovalWorkflowRepository>();
builder.Services.AddScoped<IApprovalWorkflowServices, ApprovalWorkflowServices>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
