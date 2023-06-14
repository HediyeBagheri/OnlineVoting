using CinamaTicket.Application.Services.Users;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using OnlineVoting.Application.Contract.IServices;
using OnlineVoting.Application.Contract.IServices.Users;
using OnlineVoting.Application.Contract.MappingConfoguration;
using OnlineVoting.Application.Servises;
using OnlineVoting.EndPoint.Middlewares;
using OnlineVoting.EndPoint.Securities;
using OnlineVoting.InfraSturacture.Context;
using OnlineVoting.InfraSturacture.IRepositories;
using OnlineVoting.InfraSturacture.Repositories;
using OnlineVoting.Model.IdentityModels;
using System.Text;
using TokenHandler = OnlineVoting.EndPoint.Securities.TokenHandler;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Ordering HTTP API",
        Version = "v1",
        Description = "The Ordering Service HTTP API",
    });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the bearer scheme",
        Name = "Authorization",
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                }
            },
            new List<string>()
        }
    });
});

builder.Services.AddHttpClient();

RegisterServices(builder);

//builder.Services.AddDbContext<OnlineVotingContext>(
//x => x.UseSqlServer(builder.Configuration.GetConnectionString("OnlineVoting")));
builder.Services.AddDbContextPool<OnlineVotingContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("OnlineVoting")));

builder.Services
    .AddIdentityCore<ApplicationUser>()
    .AddRoles<ApplicationRole>()
    .AddEntityFrameworkStores<OnlineVotingContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
   .AddJwtBearer(cfg =>
   {
       cfg.TokenValidationParameters = new TokenValidationParameters()
       {
           ValidateIssuer = false,
           ValidateAudience = false,
           ValidateIssuerSigningKey = true,
           RequireExpirationTime = true,
           IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("vjhgjhgbk32ییسشjkjloij6576hiuhiujhgh87y"))
       };
   });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("SupportPolicy",
    policyBuilder => policyBuilder.RequireRole("Support"));
});

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:5196")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");
app.UseStaticFiles();
app.UseMiddleware(typeof(CustomExceptionHandlerMiddleware));

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();

static void RegisterServices(WebApplicationBuilder builder)
{
    builder.Services.AddScoped<IUserService, UserService>();
    builder.Services.AddScoped<IUserContext, UserContext>();
    builder.Services.AddSingleton<ITokenHandler, TokenHandler>();

    builder.Services.AddScoped<ICondidateRepository, CondidateRepository>();
    builder.Services.AddScoped<ICondidateService, CondidateService>();

    builder.Services.AddScoped<IAdviserRepository, AdviserRepository>();
    builder.Services.AddScoped<IAdviserService, AdviserService>();

    builder.Services.AddScoped<IVotingRepository, VotingRepository>();
    builder.Services.AddScoped<IVotingService, VotingService>();
}