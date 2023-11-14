FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task21/Task21.csproj", "Task21/"]
RUN dotnet restore "Task21/Task21.csproj"
COPY . .
WORKDIR "/src/Task21"
RUN dotnet build "Task21.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task21.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task21.dll"]
