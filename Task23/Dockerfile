FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task23/Task23.csproj", "Task23/"]
RUN dotnet restore "Task23/Task23.csproj"
COPY . .
WORKDIR "/src/Task23"
RUN dotnet build "Task23.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task23.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task23.dll"]
