using AuthPlus.Domain.Common.Utility;
using AuthPlus.Domain.Common.Utility.Mail;
using AuthPlus.Persistence.Implementation.UserOperation;
using AuthPlus.Persistence.Interface.UserOperation;
using AuthPlus.Service.Implementation;
using AuthPlus.Service.Implementation.Notification;
using AuthPlus.Service.Interface;
using AuthPlus.Service.Interface.Notification;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Adding Dependency
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService, UserService>();

builder.Services.AddTransient<IMailSender, MailSender>();
builder.Services.AddTransient<INotificationService, NotificationService>();
builder.Services.AddTransient<INotificationHandler, NotificationHandler>();


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
