Steps to follow:

docker volume create unwound - Create a volume named 'unwound'
docker run -v unwound:c:\data microsoft/windowsservercore - Start a container with the volume mapped to c:\data
Write some files to c:\data in the container, then stop the container
docker run -v unwound:c:\data microsoft/windowsservercore - Start a new container
Run dir c:\data in the new container - the files are still there