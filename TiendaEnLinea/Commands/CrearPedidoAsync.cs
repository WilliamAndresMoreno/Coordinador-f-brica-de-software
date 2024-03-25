using System;
using System.Threading.Tasks;
using TiendaEnLinea.Commands;
using MediatR;

namespace TiendaEnLinea.Aplicacion.Commands.Pedidos
{
    public class CrearPedidoAsync : IRequestHandler<CrearPedidoCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public CrearPedidoAsync(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CrearPedidoCommand request, CancellationToken cancellationToken)
        {
            // Implementación de la lógica para crear un pedido
            // ...

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
