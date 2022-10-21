using Farmacia_Milagro_De_La_Paz.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_Milagro_De_La_Paz.DAL
{
    public class ProveedorDAL
    {
        private Database db;
        public ProveedorDAL()
        {
            db = new Database();
        }

        public DataTable getAllProveedor()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Sedes";
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

        public List<ProveedorBLL> getAllSedess()
        {
            List<ProveedorBLL> listProveedor = new List<ProveedorBLL>();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Proveedor";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listProveedor.Add(new ProveedorBLL(
                                Convert.ToInt32(reader["id"]),
                                Convert.ToString(reader["laboratorios"]),
                                Convert.ToString(reader["nombre_del_encargado"]),
                                Convert.ToString(reader["telefono"]),
                                Convert.ToString(reader["direccion"])
                             ));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron registros.");
                    }
                    con.Close();
                    return listProveedor;
                }
            }
            catch
            {
                return listProveedor;
            }
        }

        public bool createSede(ProveedorBLL sede)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Proveedor (laboratorios, nombre_del_encargado, telefono, direccion) VALUES (@lab, @nom, @tel, @dir);";
                    cmd.Parameters.AddWithValue("@lab", sede.Laboratorios);
                    cmd.Parameters.AddWithValue("@nom", sede.Nombre_del_encargado);
                    cmd.Parameters.AddWithValue("@tel", sede.Telefono);
                    cmd.Parameters.AddWithValue("@dir", sede.Direccion);
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

        public bool updateSede(ProveedorBLL sede)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "UPDATE Sedes SET laboratorios = @lab, nombre_del_encargado = @nom, telefono = @tel, direccion = @dir WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", sede.Id); 
                    cmd.Parameters.AddWithValue("@lab", sede.Laboratorios);
                    cmd.Parameters.AddWithValue("@nom", sede.Nombre_del_encargado);
                    cmd.Parameters.AddWithValue("@tel", sede.Telefono);
                    cmd.Parameters.AddWithValue("@dir", sede.Direccion);
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

        public bool deleteSede(ProveedorBLL proveedor)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Proveedor WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", proveedor.Id);
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
