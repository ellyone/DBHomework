FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ConsoleDBApp/ConsoleDBApp.csproj", "ConsoleDBApp/"]
RUN dotnet restore "ConsoleDBApp/ConsoleDBApp.csproj"
COPY . .
WORKDIR "/src/ConsoleDBApp"
RUN dotnet build "ConsoleDBApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleDBApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleDBApp.dll"]
