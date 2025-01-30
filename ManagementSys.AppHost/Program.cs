var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ManagementSys_Deliveries_Commands_Api>("managementsys-deliveries-commands-api");

builder.Build().Run();
