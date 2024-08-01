using RealEstate_Dabber_Api.Hubs;
using RealEstate_Dabber_Api.Models.DapperContex;
using RealEstate_Dabber_Api.Models.Repositoris.CategoryRepositoris;
using RealEstate_Dabber_Api.Models.Repositoris.ProductRepositori;
using RealEstate_Dabber_Api.Models.Repositoris.ProductRepository;
using RealEstate_Dabber_Api.Repositories.BottomGridRepositories;
using RealEstate_Dabber_Api.Repositories.ContactRepositories;
using RealEstate_Dabber_Api.Repositories.EmployeeRepositories;
using RealEstate_Dabber_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using RealEstate_Dabber_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;
using RealEstate_Dabber_Api.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using RealEstate_Dabber_Api.Repositories.MessageRepositories;
using RealEstate_Dabber_Api.Repositories.PopularLocationRepositories;
using RealEstate_Dabber_Api.Repositories.ServiceRepository;
using RealEstate_Dabber_Api.Repositories.StatisticsRepositories;
using RealEstate_Dabber_Api.Repositories.TestimonialRepositories;
using RealEstate_Dabber_Api.Repositories.ToDoListRepositories;
using RealEstate_Dabber_Api.Repositories.WhoWeAreRepository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository,CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IStatisticsRepository, StatisticsRepository>();
builder.Services.AddTransient<IContactRepository, ContactRepository>();
builder.Services.AddTransient<IToDoListRepository, ToDoListRepository>();
builder.Services.AddTransient<IStatisticRepository,StatisticRepository>();
builder.Services.AddTransient<IChartRepository,ChartRepository>();
builder.Services.AddTransient<ILast5ProductsRepository,Last5ProductRepository>();
builder.Services.AddTransient<IMessageRepository,MessageRepository>();



builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
               .AllowAnyMethod()
               .SetIsOriginAllowed((host) => true)
               .AllowCredentials();
    });
});
builder.Services.AddHttpClient();

builder.Services.AddSignalR();

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

app.UseCors("CorsPolicy"); 

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHub<SignalRHub>("/signalrhub");
//localhost:1234/swagger/category/ýndex
//localhost:1234/signalrhub

app.Run();
