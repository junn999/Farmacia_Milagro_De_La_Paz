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

        public bool createEmpleado(VentasBLL ven, EmpleadosBLL emp, MedicamentosBll med, Papeleria_BLL pap)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Ventas (cantidad_productos, total, id_empleados, id_medicamentos, id_papeleria) VALUES (@cprod, @total, @idE, @idM, @idP);";
                    cmd.Parameters.AddWithValue("@cprod", ven.Cantidad_Productos);
                    cmd.Parameters.AddWithValue("@total", ven.Total);
                    cmd.Parameters.AddWithValue("@idE", emp.Id_Empleados);
                    cmd.Parameters.AddWithValue("@idM", med.Id_Medicamentos);
                    cmd.Parameters.AddWithValue("@idP", pap.Id_Papeleria);
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

        public bool updateEmpleado(VentasBLL ven, EmpleadosBLL emp, MedicamentosBll med, Papeleria_BLL pap)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Ventas (cantidad_productos, total, id_empleados, id_medicamentos, id_papeleria) VALUES (@cprod, @total, @idE, @idM, @idP);";
                    cmd.Parameters.AddWithValue("@cprod", ven.Cantidad_Productos);
                    cmd.Parameters.AddWithValue("@total", ven.Total);
                    cmd.Parameters.AddWithValue("@idE", emp.Id_Empleados);
                    cmd.Parameters.AddWithValue("@idM", med.Id_Medicamentos);
                    cmd.Parameters.AddWithValue("@idP", pap.Id_Papeleria);
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
