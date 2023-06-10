FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WeatherForecastClean.Api/WeatherForecastClean.Api.csproj", "WeatherForecastClean.Api/"]
RUN dotnet restore "WeatherForecastClean.Api/WeatherForecastClean.Api.csproj"
COPY . .
WORKDIR "/src/WeatherForecastClean.Api"
RUN dotnet build "WeatherForecastClean.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WeatherForecastClean.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WeatherForecastClean.Api.dll"]
