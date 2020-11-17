# Swarm L7 Interlock Sample

This sample demonstrates working of L7 Interlock routing with Swarm workloads. The application is built on .NET Core for Linux worker nodes. You can build the docker image locally or just nirajdock/weatherweb image directly within the docker-compose.yml. Here are the steps to run the sample:

## Steps to run the sample

1. Clone the folder locally

2. Create Docker Secrets

    ```bash
    docker secret create viz-server-cert aspnetapp.pfx
    ```

3. Create Docker Network

    ```bash
    docker network create -d overlay  webapp_net
    ```

4. Deploy Docker Stack

    ```bash
    docker stack deploy --compose-file docker-compose.yml web
    ```

5. Test the application using CURL by accessing the hosts entry specificed in the docker-compose file on port 8443 (Interlock HTTPS port)

    ```bash
    curl -vvvv -k --resolve apps.niraj.dockerps.io:8443:<public-ip-address-of-a-cluster-node> https://apps.niraj.dockerps.io:8443
    ```
