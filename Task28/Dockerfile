FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task28/Task28.csproj", "Task28/"]
RUN dotnet restore "Task28/Task28.csproj"
COPY . .
WORKDIR "/src/Task28"
RUN dotnet build "Task28.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task28.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task28.dll"]
