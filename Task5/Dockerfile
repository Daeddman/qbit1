FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task5/Task5.csproj", "Task5/"]
RUN dotnet restore "Task5/Task5.csproj"
COPY . .
WORKDIR "/src/Task5"
RUN dotnet build "Task5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task5.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task5.dll"]
