FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY ECarPool/*.csproj ./ECarPool/
RUN dotnet restore

# copy everything else and build app
COPY ECarPool/. ./ECarPool/
WORKDIR /app/ECarPool
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=build /app/ECarPool/out ./
ENTRYPOINT ["dotnet", "ECarPool.dll"]