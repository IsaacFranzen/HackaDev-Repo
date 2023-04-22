using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;
using System.Text;
using TECBank.Backend.Domains.Profiles;
using TECBank.Backend.Repository.DataContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TecBankContext>(conf => {
    var connectionString = builder.Configuration.GetConnectionString("tecbank");
    conf.UseSqlite(connectionString);
});

builder.Services.AddControllers().AddJsonOptions(options => {
        options.JsonSerializerOptions.DefaultIgnoreCondition =
               System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
});

// Authentication
var jwtSecret = builder.Configuration.GetSection("JwtSecret").Value;
var key = Encoding.ASCII.GetBytes(jwtSecret);
builder.Services.AddAuthentication(a =>
{
    a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(j => {
    j.RequireHttpsMetadata = false;
    j.SaveToken = true;
    j.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false,
    };
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(o => {
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    o.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

// AutoMapper
builder.Services.AddAutoMapper(typeof(TransacaoProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(opt =>
    {
        opt.SwaggerEndpoint("v1/swagger.json", "TEC Bank API V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseCors(x => x.AllowAnyHeader()
                  .AllowAnyMethod()
                  .AllowAnyOrigin());

app.MapControllers();

app.Run();