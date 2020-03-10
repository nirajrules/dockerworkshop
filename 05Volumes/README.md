##Steps to follow:

docker volume create unwound - Create a volume named 'unwound' <br />
docker volume inspect unwound - volumes are created in C:\ProgramData\docker\volumes <br />
docker run -v unwound:c:\data microsoft/windowsservercore - Start a container with the volume mapped to c:\data <br />
Write some files to c:\data in the container, then stop the container <br />
docker run -v unwound:c:\data microsoft/windowsservercore - Start a new container <br />
Run dir c:\data in the new container - the files are still there Mbr />
