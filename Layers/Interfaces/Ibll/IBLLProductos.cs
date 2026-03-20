using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Ibll
{
    internal interface IBLLProductos
    {
        Productos SaveProducto(Productos producto);
        Productos UpdateProducto(Productos producto);
        bool DeleteProducto(int productoID);
        Productos GetProductoByID(int productoID);
        IEnumerable<Productos> GetProductosByFiltro(string filtro);
        IEnumerable<Productos> GetProductosByFiltros(int? marcaID, int? modeloID, int? tipoDispositivoID);
        IEnumerable<Productos> GetProductosConStock();
        IEnumerable<Productos> GetAllProductos();
        bool RebajarStock(int productoID, int cantidad);
        bool AumentarStock(int productoID, int cantidad);
    }
}
