using System;
using System.Threading.Tasks;
using TiendaEnLinea.Commands;
using MediatR;

namespace TiendaEnLinea.Handlers.Pedidos
{
    public class CrearPedidoHandler : IRequestHandler<CrearPedidoCommand, Unit>
    {
        private readonly IMediator _mediator;

        public CrearPedidoHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CrearPedidoCommand request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
    }
}
