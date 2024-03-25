public class PedidoRepository : IRepository<Pedido>
{
    private readonly ApplicationDbContext _context;

    public PedidoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Pedido pedido)
    {
        _context.Pedidos.Add(pedido);
        await _context.SaveChangesAsync();
    }

    public async Task<Pedido> GetAsync(int id)
    {
        return await _context.Pedidos.FindAsync(id);
    }

    public async Task UpdateAsync(Pedido pedido)
    {
        _context.Pedidos.Update(pedido);
        await _context.SaveChangesAsync();
    }

    public async Task CancelarPedidoAsync(int id)
    {
        var pedido = await _context.Pedidos.FindAsync(id);
        pedido.Estado = EstadoPedido.Cancelado;
        await _context.SaveChangesAsync();
    }
}
