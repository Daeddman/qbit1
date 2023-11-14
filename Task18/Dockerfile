FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task18/Task18.csproj", "Task18/"]
RUN dotnet restore "Task18/Task18.csproj"
COPY . .
WORKDIR "/src/Task18"
RUN dotnet build "Task18.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task18.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task18.dll"]
