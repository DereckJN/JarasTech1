using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Idal
{
    /// <summary>Interfaz DAL para Productos.</summary>
    internal interface IDALProductos
    {
        Productos SaveProducto(Productos producto);
        Productos UpdateProducto(Productos producto);
        bool DeleteProducto(int productoID);
        Productos GetProductoByID(int productoID);
        /// <summary>Busca productos por código interno, marca o modelo.</summary>
        IEnumerable<Productos> GetProductosByFiltro(string filtro);
        /// <summary>Filtra por marca, modelo y tipo de dispositivo (Reporte A).</summary>
        IEnumerable<Productos> GetProductosByFiltros(int? marcaID, int? modeloID, int? tipoDispositivoID);
        /// <summary>Devuelve solo productos con stock mayor a 0 (validación antes de vender).</summary>
        IEnumerable<Productos> GetProductosConStock();
        IEnumerable<Productos> GetAllProductos();
        /// <summary>Rebaja stock al concretar una venta.</summary>
        bool RebajarStock(int productoID, int cantidad);
        /// <summary>Aumenta stock al ingresar mercadería.</summary>
        bool AumentarStock(int productoID, int cantidad);
    }
}
