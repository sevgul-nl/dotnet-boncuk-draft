FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim
COPY bin/Release/netcoreapp3.1/ eBoncuk/

WORKDIR /eBoncuk
ENTRYPOINT ["dotnet", "aspnetapp.dll"]