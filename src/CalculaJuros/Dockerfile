FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["CalculaJuros/CalculaJuros.csproj", "CalculaJuros/"]
COPY ["CalculaJuros.Core/CalculaJuros.Core.csproj", "CalculaJuros.Core/"]
COPY ["CalculaJuros.Services/CalculaJuros.Services.csproj", "CalculaJuros.Services/"]
COPY ["CalculaJuros.Application/CalculaJuros.Application.csproj", "CalculaJuros.Application/"]
RUN dotnet restore "CalculaJuros/CalculaJuros.csproj"
COPY . .
WORKDIR "/src/CalculaJuros"
RUN dotnet build "CalculaJuros.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CalculaJuros.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CalculaJuros.dll"]