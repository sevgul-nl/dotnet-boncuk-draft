
FROM mcr.microsoft.com/dotnet/sdk:3.1.417-bullseye-arm32v7
RUN mkdir -p /eBoncuk
WORKDIR /eBoncuk
#COPY --from=build /eBoncuk ./
COPY /out .
ENTRYPOINT ["dotnet", "eBoncuk.dll"]
