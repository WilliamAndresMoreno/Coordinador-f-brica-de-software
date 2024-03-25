public class ProductosService : IProductosService
{
    private readonly IRepository<Pedido> _pedidosRepository;

    public ProductosService(IRepository<Pedido> pedidosRepository)
    {
        _pedidosRepository = pedidosRepository;
    }

    public async Task CrearPedidoAsync(string nombreCliente, List<LineaPedido> lineasPedido)
    {
        // Implementar la lógica para crear un pedido
        var pedido = new Pedido
        {
            NombreCliente = nombreCliente,
            LineasPedido = lineasPedido,
            FechaPedido = DateTime.Now,
            Estado = EstadoPedido.Pendiente
        };

        await _pedidosRepository.AddAsync(pedido);

        // Enviar un correo electrónico de confirmación al cliente

        return pedido;
    }

    public async Task<Pedido> ObtenerPedidoAsync(int idPedido)
    {
        // Implementar la lógica para obtener un pedido
        return await _pedidosRepository.GetAsync(idPedido);
    }

    public async Task ModificarPedidoAsync(int idPedido, string nombreCliente, List<LineaPedido> lineasPedido)
    {
        // Implementar la lógica para modificar un pedido
        var pedido = await _pedidosRepository.GetAsync(idPedido);

        pedido.NombreCliente = nombreCliente;
        pedido.LineasPedido = lineasPedido;

        await _pedidosRepository.UpdateAsync(pedido);
    }

    public async Task CancelarPedidoAsync(int idPedido)
    {
        // Implementar la lógica para cancelar un pedido
        var pedido = await _pedidosRepository.GetAsync(idPedido);

        pedido.Estado = EstadoPedido.Cancelado;

        await _pedidosRepository.UpdateAsync(pedido);
    }
}
