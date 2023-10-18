FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Ecommerce-APIGateway/Ecommerce-APIGateway.csproj", "Ecommerce-APIGateway/"]
RUN dotnet restore "Ecommerce-APIGateway/Ecommerce-APIGateway.csproj"
COPY . .
WORKDIR "/src/Ecommerce-APIGateway"
RUN dotnet build "Ecommerce-APIGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ecommerce-APIGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ecommerce-APIGateway.dll"]