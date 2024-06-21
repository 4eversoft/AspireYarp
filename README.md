# YARP + Aspire + Azure Container Apps

This is a minimal repository to test the behavior of the service discovery functionality of dotNET Aspire with a YARP reverse proxy after an Azure deployment.

The structure is as follows:

| Blazor WASM |  ---> | Blazor Server + YARP | ---> | API Service |

For reasons that are not yet clear, forwarding to the correct endpoints does not seem to work in this context when using the following methods:

```
AddServiceDiscoveryDestinationResolver
AddHttpForwarderWithServiceDiscovery
```

YARP reports the following error in this case.

```
2024-06-21T18:03:38.11910  Connecting to the container 'webapp'...

2024-06-21T18:03:38.20371  Successfully Connected to container: 'webapp' [Revision: 'webapp--wj34zqk-79f9486757-k5xwc', Replica: 'webapp--wj34zqk']
info: Yarp.ReverseProxy.Configuration.ConfigProvider.ConfigurationConfigProvider[1]
      Loading proxy data from config.
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://[::]:8080
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Production
info: Microsoft.Hosting.Lifetime[0]
      Content root path: /app
info: Yarp.ReverseProxy.Forwarder.HttpForwarder[9]
      Proxying to http://apiservice.internal.jollyhill-f8dbab9a.westeurope.azurecontainerapps.io/api/v1/products HTTP/2 RequestVersionOrLower 
info: Yarp.ReverseProxy.Forwarder.HttpForwarder[56]
      Received HTTP/1.1 response 404.
```
