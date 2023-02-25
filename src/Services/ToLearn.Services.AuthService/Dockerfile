FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Services/ToLearn.Services.AuthService/ToLearn.Services.AuthService.csproj", "src/Services/ToLearn.Services.AuthService/"]
RUN dotnet restore "src/Services/ToLearn.Services.AuthService/ToLearn.Services.AuthService.csproj"
COPY . .
WORKDIR "/src/src/Services/ToLearn.Services.AuthService"
RUN dotnet build "ToLearn.Services.AuthService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ToLearn.Services.AuthService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ToLearn.Services.AuthService.dll"]
