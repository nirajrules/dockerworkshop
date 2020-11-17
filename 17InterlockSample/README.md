# Swarm L7 Interlock Sample

This sample demonstrates working of L7 Interlock routing with Swarm workloads. The application is built on .NET Core for Linux worker nodes. You can build the docker image locally or just nirajdock/weatherweb image directly within the docker-compose.yml. Here are the steps to run the sample:

## Steps to run the sample

1. Git clone the folder locally

2. Create Docker Secrets

    ```bash
    docker secret create viz-server-cert aspnetapp.pfx
    ```

3. Deploy Docker Stack

    ```bash
    docker stack deploy --compose-file docker-compose.yml web
    ```

4. Test the application using CURL trying to access the hosts entry specificed in the docker-compose file

    ```bash
    curl -vvvv -k --resolve apps.niraj.dockerps.io:8443:<public-ip-address-of-a-cluster-node> https://apps.niraj.dockerps.io:8443
    ```
