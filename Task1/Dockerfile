FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["qbit2/qbit2.csproj", "qbit2/"]
RUN dotnet restore "qbit2/qbit2.csproj"
COPY . .
WORKDIR "/src/qbit2"
RUN dotnet build "qbit2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "qbit2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "qbit2.dll"]
