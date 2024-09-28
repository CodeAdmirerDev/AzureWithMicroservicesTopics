# Use the official ASP.NET Core runtime as a base image (Change to 8.0)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base  
WORKDIR /app  
EXPOSE 80  

# Use the SDK image to build the app (Change to 8.0 SDK)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build  
WORKDIR /src  

# Since the .csproj is in the same directory as the Dockerfile, we copy it from the current directory
COPY ["DemoMicroserviceAppWithDocker.csproj", "./"]  
RUN dotnet restore "DemoMicroserviceAppWithDocker.csproj"  

# Copy all remaining files from the current directory
COPY . .  
WORKDIR "/src"  
RUN dotnet build "DemoMicroserviceAppWithDocker.csproj" -c Release -o /app/build  

# Publish the app
FROM build AS publish  
RUN dotnet publish "DemoMicroserviceAppWithDocker.csproj" -c Release -o /app/publish  

# Create the final image
FROM base AS final  
WORKDIR /app  
COPY --from=publish /app/publish .  
ENTRYPOINT ["dotnet", "DemoMicroserviceAppWithDocker.dll"]
