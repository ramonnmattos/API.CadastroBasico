using Microsoft.EntityFrameworkCore;


//Inicia Conexão com Banco De Dados
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CadastroBasicoConnection");
builder.Services.AddDbContext<CadastroBaseContext>(opts => opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

//Inicia o AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Recurso para o Pacth - Adicionar aos Controllers
builder.Services.AddControllers().AddNewtonsoftJson();

// Add services to the container.
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
