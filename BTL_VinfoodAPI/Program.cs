using BusinessLayer;
using BusinessLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add services to the container.
builder.Services.AddTransient<IDatabaseHelper, DatabaseHelper>();
builder.Services.AddTransient<IKhachHangBusiness, KhachHangBusiness>();
builder.Services.AddTransient<IKhachHangRepository, KhachHangRepository>();
builder.Services.AddTransient<INhaCungCapBusiness, NhaCungCapBusiness>();
builder.Services.AddTransient<INhaCungCapResponsitory, NhaCungCapResponsitory>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserBusiness, UserBusiness>();
builder.Services.AddTransient<IHoaDonRepository, HoaDonRepository>();
builder.Services.AddTransient<IHoaDonBusiness, HoaDonBusiness>();
builder.Services.AddTransient<ISanPhamResponsitory, SanPhamResponsitory>();
builder.Services.AddTransient<ISanPhamBusiness, SanPhamBusiness>();
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
