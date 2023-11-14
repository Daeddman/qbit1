FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task25/Task25.csproj", "Task25/"]
RUN dotnet restore "Task25/Task25.csproj"
COPY . .
WORKDIR "/src/Task25"
RUN dotnet build "Task25.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task25.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task25.dll"]
