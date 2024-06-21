var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireYarp_ApiService>("apiservice");

builder.AddProject<Projects.AspireYarp_WebApp>("webapp")
    .WithReference(apiService)
    .WithExternalHttpEndpoints();

builder.Build().Run();
