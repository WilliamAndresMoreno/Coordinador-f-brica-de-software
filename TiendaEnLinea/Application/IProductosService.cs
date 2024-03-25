public interface IProductosService
{
    Task CrearPedidoAsync(string nombreCliente, List<LineaPedido> lineasPedido);
    Task<Pedido> ObtenerPedidoAsync(int idPedido);
    Task ModificarPedidoAsync(int idPedido, string nombreCliente, List<LineaPedido> lineasPedido);
    Task CancelarPedidoAsync(int idPedido);
}
