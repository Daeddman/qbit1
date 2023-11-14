FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task9/Task9.csproj", "Task9/"]
RUN dotnet restore "Task9/Task9.csproj"
COPY . .
WORKDIR "/src/Task9"
RUN dotnet build "Task9.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task9.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task9.dll"]
