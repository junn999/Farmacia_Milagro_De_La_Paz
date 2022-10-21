using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_Milagro_De_La_Paz.BLL
{
    public class ProveedorBLL
    {
        private int id;
        private string laboratorios;
        private string nombre_del_encargado;
        private string telefono;
        private string direccion;

        public ProveedorBLL(int id, string laboratorios, string nombre_del_encargado, string telefono, string direccion)
        {
            this.id = id;
            this.laboratorios = laboratorios;
            this.nombre_del_encargado = nombre_del_encargado;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public int Id { get => id; set => id = value; }
        public string Laboratorios { get => laboratorios; set => laboratorios = value; }
        public string Nombre_del_encargado { get => nombre_del_encargado; set => nombre_del_encargado = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}

