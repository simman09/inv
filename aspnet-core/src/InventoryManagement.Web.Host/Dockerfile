FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/InventoryManagement.Web.Host/InventoryManagement.Web.Host.csproj", "src/InventoryManagement.Web.Host/"]
COPY ["src/InventoryManagement.Web.Core/InventoryManagement.Web.Core.csproj", "src/InventoryManagement.Web.Core/"]
COPY ["src/InventoryManagement.Application/InventoryManagement.Application.csproj", "src/InventoryManagement.Application/"]
COPY ["src/InventoryManagement.Core/InventoryManagement.Core.csproj", "src/InventoryManagement.Core/"]
COPY ["src/InventoryManagement.EntityFrameworkCore/InventoryManagement.EntityFrameworkCore.csproj", "src/InventoryManagement.EntityFrameworkCore/"]
WORKDIR "/src/src/InventoryManagement.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/InventoryManagement.Web.Host", "src/InventoryManagement.Web.Host"]
COPY ["src/InventoryManagement.Web.Core", "src/InventoryManagement.Web.Core"]
COPY ["src/InventoryManagement.Application", "src/InventoryManagement.Application"]
COPY ["src/InventoryManagement.Core", "src/InventoryManagement.Core"]
COPY ["src/InventoryManagement.EntityFrameworkCore", "src/InventoryManagement.EntityFrameworkCore"]
WORKDIR "/src/src/InventoryManagement.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "InventoryManagement.Web.Host.dll"]
