using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_Milagro_De_La_Paz.BLL
{
    public class EmpleadosBLL
    {
        private int id;
        private string nombre_completo;
        private string fecha_nacimiento;
        private string numero_identidad;
        private string telefono;
        private string cargo;
        private string salario;
        private string sucursal;

        public EmpleadosBLL(int id)
        {
            this.id = id;
        }

        public EmpleadosBLL(int id, string nombre_completo, string fecha_nacimiento, string numero_identidad, string telefono, string cargo, string salario, string sucursal)
        {
            this.id = id;
            this.nombre_completo = nombre_completo;
            this.fecha_nacimiento = fecha_nacimiento;
            this.numero_identidad = numero_identidad;
            this.telefono = telefono;
            this.cargo = cargo;
            this.salario = salario;
            this.sucursal = sucursal;
        }

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombre_completo; set => nombre_completo = value; }
        public string Fecha { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Dui { get => numero_identidad; set => numero_identidad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Salario { get => salario; set => salario = value; }
        public string Sucursal { get => sucursal; set => sucursal = value; }

    }
}