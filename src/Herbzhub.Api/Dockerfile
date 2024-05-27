# Dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["/Herbzhub.Api/Herbzhub.Api.csproj", "Herbzhub.Api/"]
COPY ["/Herbzhub.Infrastructure/Herbzhub.Infrastructure.csproj", "Herbzhub.Infrastructure/"]
COPY ["/Herbzhub.Models/Herbzhub.Models.csproj", "Herbzhub.Models/"]
COPY ["/Herbzub.Data/Herbzhub.Data.csproj", "Herbzub.Data/"]
RUN dotnet restore "./Herbzhub.Api/Herbzhub.Api.csproj"

COPY . .
WORKDIR "/src/Herbzhub.Api"
RUN dotnet build "./Herbzhub.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build


FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Herbzhub.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Herbzhub.Api.dll"]