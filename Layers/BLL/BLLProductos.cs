using JarasTech.Layers.DAL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces.Ibll;
using JarasTech.Layers.Interfaces.Idal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.BLL
{
    internal class BLLProductos : IBLLProductos
    {
        private readonly IDALProductos _dal = new DALProductos();

        public Productos SaveProducto(Productos p) => _dal.GetProductoByID(p.ProductoID) != null ? _dal.UpdateProducto(p) : _dal.SaveProducto(p);
        public Productos UpdateProducto(Productos p) => _dal.UpdateProducto(p);
        public bool DeleteProducto(int id) => _dal.DeleteProducto(id);
        public Productos GetProductoByID(int id) => _dal.GetProductoByID(id);
        public IEnumerable<Productos> GetProductosByFiltro(string filtro) => _dal.GetProductosByFiltro(filtro);
        public IEnumerable<Productos> GetProductosByFiltros(int? marcaID, int? modeloID, int? tipoDispositivoID) => _dal.GetProductosByFiltros(marcaID, modeloID, tipoDispositivoID);
        public IEnumerable<Productos> GetProductosConStock() => _dal.GetProductosConStock();
        public IEnumerable<Productos> GetAllProductos() => _dal.GetAllProductos();

        /// <summary>
        /// Rebaja el stock. Lanza InvalidOperationException si no hay suficiente inventario.
        /// </summary>
        public bool RebajarStock(int productoID, int cantidad)
        {
            var producto = _dal.GetProductoByID(productoID);
            if (producto == null)
                throw new InvalidOperationException($"El producto con ID {productoID} no existe.");
            if (producto.CantidadStock < cantidad)
                throw new InvalidOperationException($"Stock insuficiente. Disponible: {producto.CantidadStock}, solicitado: {cantidad}.");
            return _dal.RebajarStock(productoID, cantidad);
        }

        public bool AumentarStock(int productoID, int cantidad) => _dal.AumentarStock(productoID, cantidad);
    }
}
