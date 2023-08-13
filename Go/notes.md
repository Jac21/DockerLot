# Go Dependency Instantiation

> go mod init learn

> go mod tidy

# Run with Docker

> docker build -t uuid-go

> docker run -it --rm --name running-uuid-go uuid-go

# Compile with Docker

> docker run --rm -v "$PWD":/Users/jeremycantu/Downloads/Development/Github/DockerLot/Go/Environments/Basic/myapp -w /Users/jeremycantu/Downloads/Development/Github/DockerLot/Go/Environments/Basic/myapp golang:1.20 go build -v
