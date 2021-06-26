#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Apresentacao/CentroClinico.Apresentacao.MVC/CentroClinico.Apresentacao.MVC.csproj", "Apresentacao/CentroClinico.Apresentacao.MVC/"]
COPY ["Infra/CentroClinico.Infra.Banco/CentroClinico.Infra.Banco.csproj", "Infra/CentroClinico.Infra.Banco/"]
COPY ["Dominio/CentroClinico.Dominio/CentroClinico.Dominio.csproj", "Dominio/CentroClinico.Dominio/"]
RUN dotnet restore "Apresentacao/CentroClinico.Apresentacao.MVC/CentroClinico.Apresentacao.MVC.csproj"
COPY . .
WORKDIR "/src/Apresentacao/CentroClinico.Apresentacao.MVC"
RUN dotnet build "CentroClinico.Apresentacao.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CentroClinico.Apresentacao.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CentroClinico.Apresentacao.MVC.dll"]
