#https://hub.docker.com/_/microsoft-dotnet-core-sdk/
FROM mcr.microsoft.com/dotnet/core/sdk
WORKDIR /app
EXPOSE 80

COPY ./publish .

ENTRYPOINT ["dotnet", "OtroEF.dll"]
