# Use the official ASP.NET Core Runtime as the base image  
        FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base  
        WORKDIR /app  
        EXPOSE 80  
          
        # Use the SDK image to build the application  
        FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build  
        WORKDIR /src  
        COPY ["UserService.csproj", "./"]  
        RUN dotnet restore "UserService.csproj"  
        COPY . .  
        WORKDIR "/src"  
        RUN dotnet build "UserService.csproj" -c Release -o /app/build  
          
        # Publish the application  
        FROM build AS publish  
        RUN dotnet publish "UserService.csproj" -c Release -o /app/publish  
          
        # Final stage to build the runtime  
        FROM base AS final  
        WORKDIR /app  
        COPY --from=publish /app/publish .  
        ENTRYPOINT ["dotnet", "UserService.dll"]  

