FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task15/Task15.csproj", "Task15/"]
RUN dotnet restore "Task15/Task15.csproj"
COPY . .
WORKDIR "/src/Task15"
RUN dotnet build "Task15.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task15.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task15.dll"]
