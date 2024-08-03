FROM  mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 6000
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["MovieBookingApi/MovieBookingApi.csproj","MovieBookingApi/"]
RUN dotnet restore "MovieBookingApi/MovieBookingApi.csproj"
COPY . .
WORKDIR "/src/MovieBookingApi"
RUN dotnet build "MovieBookingApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "MovieBookingApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish

FROM base As final
WORKDIR /app
COPY  --from=publish  /app/publish .
ENTRYPOINT [ "dotnet","MovieBookingApi.dll"]



