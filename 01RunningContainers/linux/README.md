# Running Containers

## Building the docker image 

docker image build --tag <<yourname>>/printenv:v1 .

## Single Task Container
docker container run <<yourname>>/printenv:v1

## Interactive Container 
docker container run --interactive --tty <yourname>/printenv:v1 sh

## Background (detached) Container
docker container run --detach <<yourname>>/powershell-env:v1 ping localhost -c 100
docker container logs <<container ID>> | wc
docker container ls -a | grep <<container ID>>
