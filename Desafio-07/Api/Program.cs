using Microsoft.AspNetCore.Hosting;
using Desafio_07;


IHostBuilder CreateHostBuilder(string[] args){
    return Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStartup<IStartup>();
    });
}

CreateHostBuilder(args).Build().Run();