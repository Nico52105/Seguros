using ApiColmenaSeguros;
using Datos.Entidades;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Negocio.Clases;
using Seguridad;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Ingrese 'Bearer' [espacio] y luego su token en el campo de texto. \r\n\r\nEjemplo: \"Bearer 12345abcdef\"",
    });
    options.OperationFilter<AuthorizeCheckOperationFilter>();    
});

builder.Services.AddAuthentication("TokenCliente").AddScheme<AuthenticationSchemeOptions, ValidarTokenCliente>("TokenCliente", null);
builder.Services.AddDbContext<ColmenaSegurosContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DBColmenaSeguros")));
builder.Services.AddScoped<IRespuestas, Respuestas>();
builder.Services.AddScoped<ICliente, Negocio.Clases.Cliente>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
