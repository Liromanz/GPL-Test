FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Offer-API.csproj", "."]
RUN dotnet restore "Offer-API.csproj" --source https://api.nuget.org/v3/index.json
COPY . .
WORKDIR "/src/."
RUN dotnet build "Offer-API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Offer-API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Offer-API.dll"]