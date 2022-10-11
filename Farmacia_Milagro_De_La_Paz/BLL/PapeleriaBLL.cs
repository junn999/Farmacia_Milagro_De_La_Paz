using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_Milagro_De_La_Paz.BLL
{
    public class Papeleria_BLL
    {
        private int id;
        private string producto;
        private string id_proveedor;
        private string precio_compra;
        private string precio_venta;
        private string ganancia;
        private string inventario;

        public Papeleria_BLL(int id)
        {
            this.id = id;
        }

        public Papeleria_BLL(int id, string producto, string id_proveedor, string precio_compra, string precio_venta, string ganancia, string inventario)
        {
            this.id = id;
            this.producto = producto;
            this.id_proveedor = id_proveedor;
            this.precio_compra = precio_compra;
            this.precio_venta = precio_venta;
            this.ganancia = ganancia;
            this.inventario = inventario;
        }

        public int Id { get => id; set => id = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Precio_Compra { get => precio_compra; set => precio_compra = value; }
        public string Precio_venta { get => precio_venta; set => precio_venta = value; }
        public string Ganancia { get => ganancia; set => ganancia = value; }
        public string Inventario { get => inventario; set => inventario = value; }
    }
}
