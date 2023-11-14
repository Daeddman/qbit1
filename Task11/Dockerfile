FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task11/Task11.csproj", "Task11/"]
RUN dotnet restore "Task11/Task11.csproj"
COPY . .
WORKDIR "/src/Task11"
RUN dotnet build "Task11.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task11.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task11.dll"]
