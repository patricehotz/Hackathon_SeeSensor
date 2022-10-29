#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SeeSensor.Api/SeeSensor.Api.csproj", "SeeSensor.Api/"]
COPY ["SeeSensor.Repositories.MongoDB/SeeSensor.Repositories.MongoDB.csproj", "SeeSensor.Repositories.MongoDB/"]
COPY ["SeaSensor.Repositories/SeaSensor.Repositories.csproj", "SeaSensor.Repositories/"]
COPY ["SeeSensor.Services/SeeSensor.Services.csproj", "SeeSensor.Services/"]
RUN dotnet restore "SeeSensor.Api/SeeSensor.Api.csproj"
COPY . .
WORKDIR "/src/SeeSensor.Api"
RUN dotnet build "SeeSensor.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SeeSensor.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SeeSensor.Api.dll"]