FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY SpeakerAPI/dist /app
WORKDIR /app
EXPOSE 80/tcp
EXPOSE 443/tcp
ENV ASPNETCORE_ENVIRONMENT=Development
ENTRYPOINT ["dotnet", "SpeakerAPI.dll"]