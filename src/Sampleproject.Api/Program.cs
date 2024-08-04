using Microsoft.EntityFrameworkCore;
using SampleProject.Domain.Repositoties;
using SampleProject.Infra;
using SampleProject.Infra.Repositories;
using SampleProject.Application.Usecases.User.Command.Registration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddMediatR(options => options.RegisterServicesFromAssembly(typeof(RegistrationCommand).Assembly));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddDbContext<SamProDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
