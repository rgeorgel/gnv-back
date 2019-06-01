## Build da aplicação
#dotnet publish -c Release
## Gera a imagem do docker
#docker build -t gnv-no-app ./bin/Release/netcoreapp2.2/publish
## Envia o container para o Heroku
#heroku container:push web -a gnv-no-app
## Ativa o container no Heroku
#heroku container:release web -a gnv-no-app

#Login no heroku
heroku container:login
#remove container atual
heroku container:rm web -a gnv-no-app
#build da imagem
docker build -t gnv-no-app .
docker tag gnv-no-app registry.heroku.com/gnv-no-app/web
docker push registry.heroku.com/gnv-no-app/web
#publicação da imagem no heroku
heroku container:release web -a gnv-no-app