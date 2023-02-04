var builder = WebApplication.CreateBuilder(args);

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

/*
➜  ~ dotnet dev-certs https -ep ${HOME}/.aspnet/https/aspnetapp.pfx -p jac5921 
The HTTPS developer certificate was generated successfully.
➜  ~ dotnet dev-certs https --trust
 */

/*
 * docker pull mcr.microsoft.com/dotnet/samples:aspnetapp
 * docker run --rm -it -p 8000:80 -p 8001:443 -e ASPNETCORE_URLS="https://+;http://+" -e ASPNETCORE_HTTPS_PORT=8001 -e ASPNETCORE_Kestrel__Certificates__Default__Password="<CREDENTIAL_PLACEHOLDER>" -e ASPNETCORE_Kestrel__Certificates__Default__Path=c:\https\aspnetapp.pfx -v %USERPROFILE%\.aspnet\https:C:\https\ --user ContainerAdministrator mcr.microsoft.com/dotnet/samples:aspnetapp
 */
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();