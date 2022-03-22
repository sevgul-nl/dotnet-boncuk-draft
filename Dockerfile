
FROM mcr.microsoft.com/dotnet/aspnet:3.1.23-bullseye-slim-arm32v7
#RUN mkdir -p /eBoncuk
#WORKDIR /eBoncuk
#COPY --from=build /eBoncuk ./
COPY /out .
ENTRYPOINT ["dotnet", "eBoncuk.dll"]
