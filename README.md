# DevContainerSample
## A sample setup of a development container consisting of:
- A dotnet container
- A Postgres container
- A pgAdmin container

## On creation this container will:
- Create and update the database for the application in the Postgres container to the latest migrations available
- Setup the pgAdmin container to respond to http://localhost:8081, with the Postgres container allready registered

## Prerequisites
You will ONLY need [Docker Desktop](https://www.docker.com/products/docker-desktop/) and [Visual Studio Code](https://code.visualstudio.com) with the [Remote Containers extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers)  to start using the development container.

There is NO NEED TO INSTALL ANY OTHER TOOLS OR FRAMEWORKS to use this development container!
