using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_Milagro_De_La_Paz.BLL
{
    public class VentasBLL
    {
        private int id;
        private string id_empleados;
        private string id_medicamentos;
        private string id_papeleria;
        private string cantidad_productos;
        private string total;

        public VentasBLL(int id)
        {
            this.id = id;
        }

        public VentasBLL(int id, string Id_Empleados, string Id_Medicamentos, string Id_Papeleria, string Cantidad_Productos, string Total, string id_Empleados, string id_Medicamentos, string id_Papeleria, string cantidad_Productos, string total)
        {
            this.id = id;
            this.id_empleados = id_Empleados;
            this.id_medicamentos = id_Medicamentos;
            this.id_papeleria = id_Papeleria;
            this.cantidad_productos = cantidad_Productos;
            this.total = total;
        }

        public int Id { get => id; set => id = value; }
        public string Id_Empleados { get => id_empleados; set => id_empleados = value; }
        public string Id_Medicamentos { get => id_medicamentos; set => id_medicamentos = value; }
        public string Id_Papeleria { get => id_papeleria; set => id_papeleria = value; }
        public string Cantidad_Productos { get => cantidad_productos; set => cantidad_productos = value; }
        public string Total { get => total; set => total = value; }
    }
}