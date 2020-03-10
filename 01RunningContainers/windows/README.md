# Running Containers

## Building the docker image 

docker image build --tag \<yourname\>/powershell-env:v1 .

## Single Task Container
docker container run \<yourname\>/powershell-env:v1

## Interactive Container 
docker container run --interactive --tty \<yourname\>/powershell-env:v1 powershell

## Background (detached) Container
docker container run --detach \<yourname\>/powershell-env:v1 powershell Test-Connection 'localhost' -Count 100
