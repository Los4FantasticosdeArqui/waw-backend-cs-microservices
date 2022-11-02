FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["waw-auth-service/waw-auth-service.csproj", "waw-auth-service/"]
RUN dotnet restore "waw-auth-service/waw-auth-service.csproj"
COPY . .
WORKDIR "/src/waw-auth-service"
RUN dotnet build "waw-auth-service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "waw-auth-service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "waw-auth-service.dll"]
