using Farmacia_Milagro_De_La_Paz.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_Milagro_De_La_Paz.DAL
{
    public class EmpleadosDaLL
    {
        private Database db;
        private List<EmpleadosBLL> listEmpleados;

        public EmpleadosDaLL()
        {
            db = new Database();
        }

        public DataTable getAllEmpleados ()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Empleados";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch
            {
                return dt;
            }
        }

        public bool createEmpleados (EmpleadosBLL empleados)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (nombre_completo, fecha_nacimiento, numero_identidad, telefono, cargo, salario, sucursal) VALUES (@nom, @fec, @nid, @tel, @car, @sal, @suc);";
                    cmd.Parameters.AddWithValue("@nom", empleados.Nombres);
                    cmd.Parameters.AddWithValue("@fec", empleados.Fecha);
                    cmd.Parameters.AddWithValue("@nid", empleados.Dui);
                    cmd.Parameters.AddWithValue("@tel", empleados.Telefono);
                    cmd.Parameters.AddWithValue("@car", empleados.Cargo);
                    cmd.Parameters.AddWithValue("@sal", empleados.Salario);
                    cmd.Parameters.AddWithValue("@suc", empleados.Sucursal);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool updateEmpleados(Empleados_BLL empleados)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "UPDATE Empleados SET nombre_completo = @nom, fecha_nacimiento = @fec, numero_identidad = @nid, telefono = @tel, cargo = @car, salario = @sal, sucursal = @suc WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", empleados.Id);
                    cmd.Parameters.AddWithValue("@nom", empleados.Nombres);
                    cmd.Parameters.AddWithValue("@fec", empleados.Fecha);
                    cmd.Parameters.AddWithValue("@nid", empleados.Dui);
                    cmd.Parameters.AddWithValue("@tel", empleados.Telefono);
                    cmd.Parameters.AddWithValue("@car", empleados.Cargo);
                    cmd.Parameters.AddWithValue("@sal", empleados.Salario);
                    cmd.Parameters.AddWithValue("@suc", empleados.Sucursal);

                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool deleteEmpleados(EmpleadosBLL empleados)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Empleados WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", empleados.Id);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}