FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task10/Task10.csproj", "Task10/"]
RUN dotnet restore "Task10/Task10.csproj"
COPY . .
WORKDIR "/src/Task10"
RUN dotnet build "Task10.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task10.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task10.dll"]
