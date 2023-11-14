FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task27/Task27.csproj", "Task27/"]
RUN dotnet restore "Task27/Task27.csproj"
COPY . .
WORKDIR "/src/Task27"
RUN dotnet build "Task27.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task27.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task27.dll"]
