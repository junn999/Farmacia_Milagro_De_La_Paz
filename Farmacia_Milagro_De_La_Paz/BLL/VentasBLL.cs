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
        private string ID_Empleados;
        private string ID_Medicamentos;
        private string Id_Papeleria;
        private string Cantidad_Productos;
        private string Total;

        public VentasBLL(int id, string Id_Empleados, string Id_Medicamentos, string Id_Papeleria, string Cantidad_Productos, string Total)
        {
            this.id = id;
            this.Id_Empleados = Id_Empleados;
            this.Id_Medicamentos = Id_Medicamentos;
            this.Id_Papeleria = Id_Papeleria;
            this.Cantidad_Productos = Cantidad_Productos;
            this.Total = Total;
        }

        public int Id { get => id; set => id = value; }
        public string Id_Empleados { get => Id_Empleados; set => Id_Empleados = value; }
        public string Id_Medicamentos { get => Id_Medicamentos; set => Id_Medicamentos = value; }
        public string Id_Papeleria1 { get => Id_Papeleria; set => Id_Papeleria = value; }
        public string Cantidad_Productos { get => Cantidad_Productos; set => Cantidad_Productos = value; }
        public string Total { get => Total; set => Total = value; }
    }
}
