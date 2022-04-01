# build the app as production and output to /app
FROM mcr.microsoft.com/dotnet/sdk:6.0 as build

WORKDIR /source
COPY . /source/
RUN dotnet publish -c release -o /app

# # run the production app with another image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app ./

# EXPOSE 5001
# ENTRYPOINT ["dotnet","DvlaProject.dll"]
# CMD [“/bin/bash”, “-c”, “dotnet restore && dotnet run”]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet DvlaProject.dll

