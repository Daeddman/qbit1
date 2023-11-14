FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task17/Task17.csproj", "Task17/"]
RUN dotnet restore "Task17/Task17.csproj"
COPY . .
WORKDIR "/src/Task17"
RUN dotnet build "Task17.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task17.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task17.dll"]
