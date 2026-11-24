# DockerLot

🐳 **DockerLot** is a collection of Docker, Docker Compose, Docker Swarm, and Kubernetes examples spanning container configuration, application runtimes, databases, message brokers, and orchestration.

The repository is intended as a practical reference and learning environment for building, composing, deploying, and inspecting containerized workloads.

## Repository structure

| Path | Contents |
| --- | --- |
| [`Docker/`](Docker/) | Docker configuration and miscellaneous container examples |
| [`Kubernetes/`](Kubernetes/) | Kubernetes pod examples and notes |
| [`Swarm/`](Swarm/) | Docker Swarm stack examples and notes |
| [`Databases/`](Databases/) | PostgreSQL and Redis container examples |
| [`MessageBrokers/`](MessageBrokers/) | Kafka container examples |
| [`DotNet/`](DotNet/) | ASP.NET and Kubernetes examples for .NET 6 |
| [`Go/`](Go/) | Go environment and container examples |
| [`Python/`](Python/) | Python starter container examples |
| [`Foundations/`](Foundations/) | General container and Docker notes |

## Prerequisites

Requirements vary by example. The most common tools are:

- [Docker](https://www.docker.com/) with Docker Compose
- [Docker Swarm](https://docs.docker.com/engine/swarm/) for stack deployments
- [kubectl](https://kubernetes.io/docs/tasks/tools/) and access to a Kubernetes cluster
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Go](https://go.dev/dl/) and/or [Python](https://www.python.org/) for language-specific examples

## Getting started

Clone the repository:

```bash
git clone https://github.com/Jac21/DockerLot.git
cd DockerLot
```

Choose an example directory and review its files before running it. Many examples use Docker Compose and are started from the directory containing the Compose file:

```bash
docker compose up --build
```

Stop the example and remove its containers with:

```bash
docker compose down
```

## Docker

The [`Docker/`](Docker/) directory contains configuration and miscellaneous examples. The [`Databases/`](Databases/) and [`MessageBrokers/`](MessageBrokers/) directories provide containers for PostgreSQL, Redis, and Kafka workloads.

## Kubernetes

The [`Kubernetes/`](Kubernetes/) directory contains basic pod examples, while [`DotNet/Kubernetes/`](DotNet/Kubernetes/) includes a .NET application with backend and frontend Kubernetes deployments.

Typical Kubernetes commands include:

```bash
kubectl apply -f <manifest>.yml
kubectl get pods
kubectl get deployments
kubectl delete deployment <deployment-name>
```

## Docker Swarm

The [`Swarm/`](Swarm/) directory contains Swarm stack examples. Before deploying a stack, initialize or join a Swarm and review the stack file for its services and configuration.

```bash
docker stack deploy -c <stack-file>.yml <stack-name>
docker stack services <stack-name>
docker stack rm <stack-name>
```

## Contributing

Contributions are welcome. Please keep examples focused and include a brief explanation of any prerequisites, environment variables, ports, or external services required to run them.

Before submitting a change:

1. Review the files in the example directory.
2. Test Docker Compose, Swarm, or Kubernetes commands locally where applicable.
3. Avoid committing secrets, credentials, or machine-specific state.
4. Use descriptive file and directory names.

## License

This repository is licensed under the [MIT License](LICENSE).
