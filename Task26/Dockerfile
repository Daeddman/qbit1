FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task26/Task26.csproj", "Task26/"]
RUN dotnet restore "Task26/Task26.csproj"
COPY . .
WORKDIR "/src/Task26"
RUN dotnet build "Task26.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task26.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task26.dll"]
