# Docker Swarm set-up and usage

> docker system info

> docker swarm init

> docker service create --name demo alpine:latest ping 8.8.8.8

> docker service ps demo

> docker servie logs demo

> docker service rm demo

# Deployment

> docker stack deploy -c bb-stack.yaml demo

> docker service ls

> docker stack rm demo