FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Project.web.Web.Host/Project.web.Web.Host.csproj", "src/Project.web.Web.Host/"]
COPY ["src/Project.web.Web.Core/Project.web.Web.Core.csproj", "src/Project.web.Web.Core/"]
COPY ["src/Project.web.Application/Project.web.Application.csproj", "src/Project.web.Application/"]
COPY ["src/Project.web.Core/Project.web.Core.csproj", "src/Project.web.Core/"]
COPY ["src/Project.web.EntityFrameworkCore/Project.web.EntityFrameworkCore.csproj", "src/Project.web.EntityFrameworkCore/"]
WORKDIR "/src/src/Project.web.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Project.web.Web.Host", "src/Project.web.Web.Host"]
COPY ["src/Project.web.Web.Core", "src/Project.web.Web.Core"]
COPY ["src/Project.web.Application", "src/Project.web.Application"]
COPY ["src/Project.web.Core", "src/Project.web.Core"]
COPY ["src/Project.web.EntityFrameworkCore", "src/Project.web.EntityFrameworkCore"]
WORKDIR "/src/src/Project.web.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Project.web.Web.Host.dll"]
