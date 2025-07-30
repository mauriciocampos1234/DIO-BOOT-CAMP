namespace ProgramacaoDoZero
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // 👇 Adiciona a política de CORS com origem específica e suporte a credenciais
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder
                        .WithOrigins("http://localhost:5500") // 👈 Altere aqui conforme sua origem
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials(); // 👈 Necessário para withCredentials = true
                });
            });

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
                
            }

            app.UseHttpsRedirection();

            // 👇 Ativa o CORS antes de mapear rotas
            // app.UseCors("CorsPolicy");

            app.UseRouting();

            app.UseCors(x => x
                .SetIsOriginAllowed(origin => true)
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
