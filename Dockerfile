#mcr.microsoft.com/dotnet/aspnet:3.1.23-bullseye-slim-arm32v7
#mcr.microsoft.com/dotnet/aspnet:5.0
#mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim
#COPY bin/Release/netcoreapp3.1/ eBoncuk/

FROM mcr.microsoft.com/dotnet/aspnet:6.0-bullseye-slim-arm32v7
WORKDIR /eBoncuk
COPY --from=build /eBoncuk ./
ENTRYPOINT ["./eBoncuk"]