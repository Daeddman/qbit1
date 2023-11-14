FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task8/Task8.csproj", "Task8/"]
RUN dotnet restore "Task8/Task8.csproj"
COPY . .
WORKDIR "/src/Task8"
RUN dotnet build "Task8.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task8.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task8.dll"]
