using Farmacia_Milagro_De_La_Paz.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_Milagro_De_La_Paz.DAL
{
    public class VentasDAL
    {
        private Database db;
        public VentasDAL()
        {
            db = new Database();
        }


        public DataTable getAllVentas()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Ventas";
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

        public bool createEmpleado(VentasBll ven, EmpleadosBLL ven, MedicamentosBLL, PapeleriaBLL pap, ProveedorBLL prov)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Ventas (nombres, apellidos, email, telefono, id_sede, dui, id_cargo) VALUES (@nom, @ap, @em, @tel, @idS, @dui, @idC);";
                    cmd.Parameters.AddWithValue("@nom", ven.Nombres);
                    cmd.Parameters.AddWithValue("@ap", ven.Apellidos);
                    cmd.Parameters.AddWithValue("@em", ven.Email);
                    cmd.Parameters.AddWithValue("@tel", ven.Telefono);
                    cmd.Parameters.AddWithValue("@idS", sede.Id);
                    cmd.Parameters.AddWithValue("@dui", ven.Dui);
                    cmd.Parameters.AddWithValue("@idC", cargo.Id);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.GetBaseException());
                return false;
            }
        }

        public bool updateEmpleado(EmpleadosBLL emp, SedesBLL sede, CargosBLL cargo)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "UPDATE Empleados SET nombres = @nom, apellidos = @ap, email = @em, telefono = @tel, id_sede = @idS, dui = @dui, id_cargo = @idC WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", emp.Id);
                    cmd.Parameters.AddWithValue("@nom", emp.Nombres);
                    cmd.Parameters.AddWithValue("@ap", emp.Apellidos);
                    cmd.Parameters.AddWithValue("@em", emp.Email);
                    cmd.Parameters.AddWithValue("@tel", emp.Telefono);
                    cmd.Parameters.AddWithValue("@idS", sede.Id);
                    cmd.Parameters.AddWithValue("@dui", emp.Dui);
                    cmd.Parameters.AddWithValue("@idC", cargo.Id);
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

        public bool deleteEmpleado(EmpleadosBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Empleados WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", emp.Id);
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
