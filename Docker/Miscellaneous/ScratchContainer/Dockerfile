FROM golang:1.20 as builder

WORKDIR /tmp/go
COPY hello.go ./
COPY go.mod ./
RUN CGO_ENABLED=0 GOOS=linux GOARCH=amd64 go build -a -ldflags '-s' -o hello

# https://hub.docker.com/_/scratch/
FROM scratch
CMD [ "/hello" ]
COPY --from=builder /tmp/go/hello /hello