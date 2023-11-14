FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task30/Task30.csproj", "Task30/"]
RUN dotnet restore "Task30/Task30.csproj"
COPY . .
WORKDIR "/src/Task30"
RUN dotnet build "Task30.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task30.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task30.dll"]
