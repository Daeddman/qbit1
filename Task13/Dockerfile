FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task13/Task13.csproj", "Task13/"]
RUN dotnet restore "Task13/Task13.csproj"
COPY . .
WORKDIR "/src/Task13"
RUN dotnet build "Task13.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task13.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task13.dll"]
