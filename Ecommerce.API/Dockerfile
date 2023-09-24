#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Ecommerce.API/Ecommerce.API.csproj", "Ecommerce.API/"]
COPY ["Ecommerce.Abstractions/Ecommerce.Abstractions.csproj", "Ecommerce.Abstractions/"]
COPY ["Ecommerce.Model/Ecommerce.Model.csproj", "Ecommerce.Model/"]
COPY ["Ecommerce.BLL/Ecommerce.BLL.csproj", "Ecommerce.BLL/"]
COPY ["Ecommerce.Configurations/Ecommerce.Configurations.csproj", "Ecommerce.Configurations/"]
COPY ["Ecommerce.Repositories/Ecommerce.Repositories.csproj", "Ecommerce.Repositories/"]
COPY ["Ecommerce.Database/Ecommerce.Database.csproj", "Ecommerce.Database/"]

RUN dotnet restore "Ecommerce.API/Ecommerce.API.csproj"
COPY . .
WORKDIR "/src/Ecommerce.API"
RUN dotnet build "Ecommerce.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ecommerce.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ecommerce.API.dll"]