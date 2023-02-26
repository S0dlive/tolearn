FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Services/ToLearn.Services.CoursesService/ToLearn.Services.CoursesService.csproj", "src/Services/ToLearn.Services.CoursesService/"]
RUN dotnet restore "src/Services/ToLearn.Services.CoursesService/ToLearn.Services.CoursesService.csproj"
COPY . .
WORKDIR "/src/src/Services/ToLearn.Services.CoursesService"
RUN dotnet build "ToLearn.Services.CoursesService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ToLearn.Services.CoursesService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ToLearn.Services.CoursesService.dll"]
