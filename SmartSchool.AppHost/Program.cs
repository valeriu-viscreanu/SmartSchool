var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.SmartSchool_Web>("smartschool.web");

builder.Build().Run();
