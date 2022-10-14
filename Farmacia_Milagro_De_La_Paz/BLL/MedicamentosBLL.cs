using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_Milagro_De_La_Paz.BLL
{
    public class MedicamentosBll
    {
        private int id;
        private string id_proveedor;
        private string nombre_del_producto;
        private string presentacion;
        private string fecha_de_caducidad;
        private string precio_de_compra;
        private string precio_de_venta;
        private string ganancia;
        private string inventario;

        public MedicamentosBll(int id)
        {
            this.id = id;
        }

        public MedicamentosBll(int id, string id_proveedor, string nombre_del_producto, string presentacion, string fecha_de_caducidad, string precio_de_compra, string precio_de_venta, string ganancia, string inventario)
        {
            this.id = id;
            this.id_proveedor = id_proveedor;
            this.nombre_del_producto = nombre_del_producto;
            this.presentacion = presentacion;
            this.fecha_de_caducidad = fecha_de_caducidad;
            this.precio_de_compra = precio_de_compra;
            this.precio_de_venta = precio_de_venta;
            this.ganancia = ganancia;
            this.inventario = inventario;
        }

        
        public int Id1 { get => id; set => id = value; }
        public string Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Nombre_del_producto { get => nombre_del_producto; set => nombre_del_producto = value; }
        public string Presentacion { get => presentacion; set => presentacion = value; }
        public string Fecha_de_caducidad { get => fecha_de_caducidad; set => fecha_de_caducidad = value; }
        public string Precio_de_compra { get => precio_de_compra; set => precio_de_compra = value; }
        public string Precio_de_venta { get => precio_de_venta; set => precio_de_venta = value; }
        public string Ganancia { get => ganancia; set => ganancia = value; }
        public string Inventario { get => inventario; set => inventario = value; }
    }
}