#exec into default-pod
kubectl exec -it pod-demo-sa sh

#install CURL
apt-get update 
apt-get install -y curl

# Get the ServiceAccount token from within the Pod's container
TOKEN=$(cat /run/secrets/kubernetes.io/serviceaccount/token)

# Call an API Server's endpoint (using the ClusterIP kubernetes service) to get all the Pods running in the default namespace
curl -H "Authorization: Bearer $TOKEN" https://kubernetes/api/v1/namespaces/default/pods/ --insecure
