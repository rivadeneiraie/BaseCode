# Base Code

Código base para la creación de proyecto en Net Core 8

## Base de datos SQL server 

dotnet ef migrations add InitialCreate --startup-project ../WebApi/WebApi.csproj

dotnet ef database update --startup-project ../WebApi/WebApi.csproj 

sqlcmd -S localhost -U sa -P 'Poty2011' -C