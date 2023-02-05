# k8s

## Deployment 

> kubectl apply -f k8s/postgres.yaml

> kubectl apply -f k8s/api.yaml

## Validation

> kubectl get deployment

> kubectl get pods

## Service Information

> kubectl get service

## Database Information

> kubectl get pv

> kubectl get pvc

## Scaling

> kubectl apply -f https://github.com/kubernetes-sigs/metrics-server/releases/download/v0.4.1/components.yaml

> kubectl autoscale deployment dot-net-six-demo-api
--cpu-percent=10 --min=1 --max=10