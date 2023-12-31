﻿FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DotNetAPI/DotNetAPI.csproj", "DotNetAPI/"]
RUN dotnet restore "DotNetAPI/DotNetAPI.csproj"
COPY . .
WORKDIR "/src/DotNetAPI"
RUN dotnet build "DotNetAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DotNetAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotNetAPI.dll"]
