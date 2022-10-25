# DevContainerSample
## A sample setup of a development container consisting of:
- A dotnet and node container (Frontend and backend applications)
- A Postgres container (DB engine)
- A pgAdmin container (DB admin tool)
- A Seq container (Logging)
- An Nginx container (Reverse proxy)

## On creation this container will:
- Create and update the database for the application in the Postgres container to the latest migrations available
- Setup the pgAdmin container to respond to http://localhost:8088, with the Postgres container allready registered
- Setup the Seq container to respond to http://localhost:8089 ready to receive logs
- Serves the application at http://localhost:8081 hosted from kestrel (Start by pressing `F5` in VS code) and the node devserver (Start by typing `npm start` at the terminal)
- Serves the application at http://localhost:8080 hosted from kestrel (Start by pressing `F5` in VS code) and the static website (Build by typing `npm run build` at the terminal)

## Prerequisites
You will ONLY need [Docker Desktop](https://www.docker.com/products/docker-desktop/) and [Visual Studio Code](https://code.visualstudio.com) with the [Remote Containers extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers)  to start using the development container.

There is NO NEED TO INSTALL ANY OTHER TOOLS OR FRAMEWORKS to use this development container!
