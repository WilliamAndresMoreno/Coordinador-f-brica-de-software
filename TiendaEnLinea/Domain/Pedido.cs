public class Pedido
{
    // Propiedades de la clase
    public int Id { get; set; }
    public string Cliente { get; set; }
    public DateTime Fecha { get; set; }
    public List<LineaPedido> LineasPedido { get; set; }

    // ... (Aquí puedes agregar otras propiedades y métodos)
}

public class LineaPedido
{
    // Propiedades de la clase anidada
    public int Id { get; set; }
    public int ProductoId { get; set; }
    public string Descripcion { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }

    // ... (Aquí puedes agregar otras propiedades y métodos)
}
