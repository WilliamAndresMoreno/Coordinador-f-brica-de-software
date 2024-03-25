using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TiendaEnLinea.DataAccess;
using TiendaEnLinea.Handlers.Pedidos;
using MediatR;

namespace TiendaEnLinea
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();

                var command = new CrearPedidoCommand
                {
                    // Propiedades del comando para crear un pedido
                    // ...
                };

                await mediator.Send(command);
            }

            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseInMemoryDatabase("TiendaEnLinea"));

                    services.AddMediatR(typeof(Program).Assembly);

                    // Puedes agregar aquí otros servicios que sean necesarios para tu proyecto
                    // ...
                });
    }