using DinkToPdf;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Configuration;
using System.Reflection;
using System.Text;
using VehicalRentalSystem1.Middleware;
using VehicalRentalSystem1.Models;
using VehicalRentalSystem1.Services;
using VehicalRentalSystem1.ViewModel;
using Owin;
using Microsoft.Owin;
using static Microsoft.AspNetCore.SignalR.Hub;

//var builder = WebApplication.CreateBuilder(args);
//builder.Configuration.AddJsonFile("appsettings.json");

var builder = WebApplication.CreateBuilder(args);

var key = Encoding.ASCII.GetBytes("hfyrutjyikuldfertokgjhuynbjgkfldk");
builder.Services.AddSignalR();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });
   
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
});



builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddScoped<ValidationService>();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<RegistrationService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddSignalR();


builder.Services.AddScoped<ValidationService>();
builder.Services.AddScoped<VehicalService>();
builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("SmtpSettings"));
builder.Services.AddSingleton<IEmailService, SmtpEmailService>();
builder.Services.AddSingleton(typeof(DinkToPdf.Contracts.IConverter), new SynchronizedConverter(new PdfTools()));
builder.Services.AddControllersWithViews(); ;
var provider = builder.Services.BuildServiceProvider();
var config = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<VehicalRentalSystemContext>(item => item.UseSqlServer(config.GetConnectionString("dbcs")));


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignOutScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
    {
       
        options.Cookie.Name = "YourCookieName";
       
    })
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
    {
        // Configure JWT authentication options here
    });


var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API V1");
    });
}
app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<JwtMiddleware>();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
   );

app.MapHub<ChatHub>("/chat");

app.Run();