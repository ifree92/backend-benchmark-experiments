FROM microsoft/dotnet:2.2-aspnetcore-runtime-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk-stretch AS build
WORKDIR /src
COPY ["WebUsersApp/WebUsersApp.csproj", "WebUsersApp/"]
RUN dotnet restore "WebUsersApp/WebUsersApp.csproj"
COPY . .
WORKDIR "/src/WebUsersApp"
RUN dotnet build "WebUsersApp.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WebUsersApp.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebUsersApp.dll"]