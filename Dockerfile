FROM mcr.microsoft.com/dotnet/aspnet:3.1-focal AS base
WORKDIR /app
EXPOSE 80

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:3.1-focal AS build
WORKDIR /src
COPY ["ContactApp.Api/ContactApp.Api.csproj", "ContactApp.Api/"]
RUN dotnet restore "ContactApp.Api/ContactApp.Api.csproj"
COPY . .
WORKDIR "/src/ContactApp.Api"
RUN dotnet build "ContactApp.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContactApp.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContactApp.Api.dll"]
