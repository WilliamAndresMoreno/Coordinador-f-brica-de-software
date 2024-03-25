public class ObtenerPedidoHandler : IRequestHandler<ObtenerPedidoQuery, Pedido>
{
    private readonly ApplicationDbContext _context;

    public ObtenerPedidoHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Pedido> Handle(ObtenerPedidoQuery request, CancellationToken cancellationToken)
    {
        return await _context.Pedidos.FindAsync(request.Id);
    }
}
