#FROM microsoft/dotnet:2.2-aspnetcore-runtime
#WORKDIR /app
#COPY . .
#CMD ASPNETCORE_URLS=http://*:$PORT dotnet gnv-back.dll


FROM microsoft/dotnet:2.2-sdk as build-environment

WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o /app/deploy-api

FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app
COPY --from=build-environment /app/deploy-api .

#Heroku command
#CMD ASPNETCORE_URLS=http://*:$PORT dotnet gnv-back.dll

ENTRYPOINT ["dotnet", "gnv-back.dll"]