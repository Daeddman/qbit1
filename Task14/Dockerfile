FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task14/Task14.csproj", "Task14/"]
RUN dotnet restore "Task14/Task14.csproj"
COPY . .
WORKDIR "/src/Task14"
RUN dotnet build "Task14.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task14.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task14.dll"]
