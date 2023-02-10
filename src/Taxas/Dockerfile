FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Taxas/Taxas.csproj", "Taxas/"]
COPY ["Taxas.Application/Taxas.Application.csproj", "Taxas.Application/"]
RUN dotnet restore "Taxas/Taxas.csproj"
COPY . .
WORKDIR "/src/Taxas"
RUN dotnet build "Taxas.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Taxas.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Taxas.dll"]