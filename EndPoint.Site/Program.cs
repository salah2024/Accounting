//using Accounting.Application.Interface.Context;
//using Accounting.Application.Interface.FacadPattern;
//using Accounting.Application.Services.FacadPattern;
//using Accounting.Persistence.Context;
//using Microsoft.EntityFrameworkCore;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddScoped<IDataBaseContext, DataBaseContext>();
//builder.Services.AddScoped<IRoleFacad, RoleFacad>();
//builder.Services.AddScoped<IRoleTaskFacad, RoleTaskFacad>();
//builder.Services.AddScoped<ITaskFacad, TaskFacad>();
//builder.Services.AddScoped<IUserFacad, UserFacad>();

//string connectionString = "Data Source=DESKTOP-7BESJJS;Initial Catalog=AccountingSys;Integrated Security=True;";
//builder.Services.AddControllersWithViews();
//builder.Services.AddEntityFrameworkSqlServer().AddDbContext<DataBaseContext>(option => option.UseSqlServer(connectionString));

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
////if (app.Environment.IsDevelopment())
////{
////    app.UseSwagger();
////    app.UseSwaggerUI();
////}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "api/{controller}/{action}/{id?}");

//app.Run();




using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.FacadPattern;
using Accounting.Application.Interface.Language_LanguageKeyValue.Queries.GetLanguageAndLanguageKeyValueEqualAll;
using Accounting.Application.Services.FacadPattern;
using Accounting.Application.Services.Language.Queries.GetAllLanguage;
using Accounting.Common.Dto;
using Accounting.Persistence.Context;
using EndPoint.Site;
using EndPoint.Site.Resource;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDataBaseContext, DataBaseContext>();
builder.Services.AddScoped<IRoleFacad, RoleFacad>();
builder.Services.AddScoped<IRoleTaskFacad, RoleTaskFacad>();
builder.Services.AddScoped<ITaskFacad, TaskFacad>();
builder.Services.AddScoped<IUserFacad, UserFacad>();
builder.Services.AddScoped<ILanguage_LanguageKeyValueFacad, Language_LanguageKeyValueFacad>();
builder.Services.AddScoped<ILanguageFacad, LanguageFacad>();
builder.Services.AddScoped<ILanguageKeyValueFacad, LanguageKeyValueFacad>();


IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
//string connectionString = "Data Source=DESKTOP-7BESJJS;Initial Catalog=AccountingSys;user id=sa;password=123456;";
builder.Services.AddControllersWithViews();
builder.Services.AddEntityFrameworkSqlServer().AddDbContext<DataBaseContext>(option => option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
//builder.Services.AddLocalization(options => options.ResourcesPath="Resource");
builder.Services.AddControllers();


builder.Services.AddLocalization(option => option.ResourcesPath = "Resource");
builder.Services.AddSingleton<LocalizationService>();
builder.Services.AddMvc()
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization(options =>
    {
        options.DataAnnotationLocalizerProvider = (type, factory) =>
        {
           var assemblyName = new AssemblyName(typeof(ApplicationResource).GetTypeInfo().Assembly.FullName);
           return factory.Create("ApplicationResource",assemblyName.Name);
        };
    });

var supportedCultures = new List<CultureInfo>()
{
    new CultureInfo("fa-IR"),
    new CultureInfo("en-US"),
    new CultureInfo("ku-IR"),
};

var app = builder.Build();
var options = new RequestLocalizationOptions()
{
    DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("fa-IR"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures,
    RequestCultureProviders = new List<IRequestCultureProvider>()
    {
        new QueryStringRequestCultureProvider(),
        new CookieRequestCultureProvider()
    }
};
app.UseRequestLocalization(options);
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

