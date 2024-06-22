using RealEstateProjectSale.Mapper;
using RealEstateProjectSaleRepository.IRepository;
using RealEstateProjectSaleRepository.Repository;
using RealEstateProjectSaleServices.IServices;
using RealEstateProjectSaleServices.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Mapper
builder.Services.AddAutoMapper(typeof(ApplicationMapper));

//Add Scoped
builder.Services.AddScoped<IStaffRepo, StaffRepo>();
builder.Services.AddScoped<IStaffServices, StaffServices>();
builder.Services.AddScoped<IAccountRepo, AccountRepo>();
builder.Services.AddScoped<IAccountServices, AccountServices>();
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<ICustomerServices, CustomerServices>();
builder.Services.AddScoped<IProjectRepo, ProjectRepo>();
builder.Services.AddScoped<IProjectServices, ProjectServices>();






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
