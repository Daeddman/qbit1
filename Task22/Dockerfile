FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task22/Task22.csproj", "Task22/"]
RUN dotnet restore "Task22/Task22.csproj"
COPY . .
WORKDIR "/src/Task22"
RUN dotnet build "Task22.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task22.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task22.dll"]
