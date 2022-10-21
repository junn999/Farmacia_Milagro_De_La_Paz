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
    public class MedicamentosDAL
    {
        private Database db;
        public MedicamentosDAL()
        {
            db = new Database();
        }

        public DataTable getAllMedicamentos()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Medicamentos";
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


        public bool createMedicamentos (MedicamentosBll sede)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Sedes (Nombre_del_producto, Presentacion, Fecha_de_caducidad, Precio_de_compra, Precio_de_venta, Ganancia, Inventario) VALUES (@nom, @pre, @fe, @prec, @prev, @gan, @inv);";
                    cmd.Parameters.AddWithValue("@nom", sede.Nombre_del_producto);
                    cmd.Parameters.AddWithValue("@pre", sede.Presentacion);
                    cmd.Parameters.AddWithValue("@fe", sede.Fecha_de_caducidad);
                    cmd.Parameters.AddWithValue("@prec", sede.Precio_de_compra);
                    cmd.Parameters.AddWithValue("@prev", sede.Precio_de_venta);
                    cmd.Parameters.AddWithValue("@gan", sede.Ganancia);
                    cmd.Parameters.AddWithValue("@inv", sede.Inventario);
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

        public bool updateMedicamentos (MedicamentosBll medicamentos)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "UPDATE Sedes SET Nombre_del_producto = @nom, Presentacion = @pre, Fecha_de_caducidad = @fe, Precio_de_compra = @prec, Precio_de_venta = @prev, Ganancia = @gan, Inventario = @inv WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@nom", medicamentos.Nombre_del_producto);
                    cmd.Parameters.AddWithValue("@pre", medicamentos.Presentacion);
                    cmd.Parameters.AddWithValue("@fe", medicamentos.Fecha_de_caducidad);
                    cmd.Parameters.AddWithValue("@prec", medicamentos.Precio_de_compra);
                    cmd.Parameters.AddWithValue("@prev", medicamentos.Precio_de_venta);
                    cmd.Parameters.AddWithValue("@gan", medicamentos.Ganancia);
                    cmd.Parameters.AddWithValue("@inv", medicamentos.Inventario);
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

        public bool deleteMedicamentos (MedicamentosBll sede)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Medicamentos WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", sede.Id);
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
