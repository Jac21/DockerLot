# Aerospike start-up

> docker-compose up

# Usage

> docker run -ti aerospike/aerospike-tools:latest aql -h  $(docker inspect -f '{{.NetworkSettings.IPAddress }}' aerospike)

> docker run --platform linux/amd64 -ti aerospike/aerospike-tools:latest aql