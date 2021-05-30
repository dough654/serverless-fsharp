module Config 
    
    open System.IO
    open Microsoft.Extensions.Configuration

    [<CLIMutable>]
    type Configuration = {
        connectionString: string
    }
    let getConfig =
        let builder = (new ConfigurationBuilder())
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json", true, true)
                          .AddEnvironmentVariables(); 
        let configurationRoot = builder.Build();
        configurationRoot.Get<Configuration>()