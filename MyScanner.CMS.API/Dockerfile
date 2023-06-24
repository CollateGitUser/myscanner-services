#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MyScanner.CMS.API/MyScanner.CMS.API.csproj", "MyScanner.CMS.API/"]
RUN dotnet restore "MyScanner.CMS.API/MyScanner.CMS.API.csproj"
COPY . .
WORKDIR "/src/MyScanner.CMS.API"
RUN dotnet build "MyScanner.CMS.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyScanner.CMS.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyScanner.CMS.API.dll"]