# Etapa 1: Compilar la app .NET
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["PatitasRefugiosApi.csproj", "."]
RUN dotnet restore "PatitasRefugiosApi.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet publish "PatitasRefugiosApi.csproj" -c Release -o /app/publish

# Etapa 2: Ejecutar la app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "PatitasRefugiosApi.dll"]