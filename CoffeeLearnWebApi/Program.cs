using CoffeeLearnWebApi;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CoffeeLearnDbContext>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                   .AddJwtBearer(options =>
                   {
                       options.RequireHttpsMetadata = false;
                       options.TokenValidationParameters = new TokenValidationParameters
                       {
                           ValidateIssuer = true,
                           ValidIssuer = AuthOptions.ISSUER,

                           ValidateAudience = true,

                           ValidAudience = AuthOptions.AUDIENCE,

                           ValidateLifetime = true,

                           IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Constants.KeyString)),
                           ValidateIssuerSigningKey = true,
                       };
                   });
builder.Services.AddControllersWithViews();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseDefaultFiles();

app.UseStaticFiles();

app.UseRouting();

app.UseHttpsRedirection();

app.MapControllers();


app.UseDeveloperExceptionPage();


app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.Run();
