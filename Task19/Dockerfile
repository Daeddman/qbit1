FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task19/Task19.csproj", "Task19/"]
RUN dotnet restore "Task19/Task19.csproj"
COPY . .
WORKDIR "/src/Task19"
RUN dotnet build "Task19.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task19.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task19.dll"]
