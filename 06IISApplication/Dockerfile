# escape=`
FROM microsoft/dotnet-framework:4.7.2-sdk-windowsservercore-ltsc2019 AS builder

WORKDIR C:\src\SampleIISApp
COPY src\SampleIISApp\packages.config .
RUN nuget restore packages.config -PackagesDirectory ..\packages

COPY src C:\src
RUN msbuild SampleIISApp.csproj /p:OutputPath=c:\out /p:Configuration=Release

# app image
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.7.2-windowsservercore-ltsc2019
SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop'; $ProgressPreference = 'SilentlyContinue';"]

WORKDIR C:\SampleIISApp

RUN Remove-Website -Name 'Default Web Site'; `
    New-Website -Name 'SampleIISApp' `
                -Port 80 -PhysicalPath 'c:\SampleIISApp' `
                -ApplicationPool '.NET v4.5'

COPY --from=builder C:\out\_PublishedWebsites\SampleIISApp C:\SampleIISApp

ENTRYPOINT ["powershell", "sample.ps1"]