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
                                Convert.ToString(reader["nombre_del_encargado"])
                                Convert.ToString(reader["telefono"])
                                Convert.ToString(reader["direccion"])
                          ))));
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
    }
}
