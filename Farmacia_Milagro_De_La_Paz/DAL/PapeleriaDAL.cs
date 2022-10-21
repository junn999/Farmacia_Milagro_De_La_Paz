using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_Milagro_De_La_Paz.DAL
{

    public class PapeleriaDAL
    {
        private Database db;
        public PapeleriaDAL()
        {
            db = new Database();
        }

        public DataTable getAllPapeleria()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Papeleria";
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

        public List<PapeleriaBLL> getAllPapeleria()
        {
            List<SedesBLL> listPapeleria= new List<PapeleriaBLL>();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Papeleria";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSedes.Add(new PapeleriaBLL(
                                Convert.ToInt32(reader["id"]),
                                Convert.ToString(reader["Producto"]),
                                Convert.ToString(reader["Precio_compra"]),
                                Convert.ToString(reader["Precio_venta"]),
                                Convert.ToString(reader["Ganancia"]),
                                Convert.ToString(reader["Inventario"])
                              
                            ));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron registros.");
                    }
                    con.Close();
                    return listPapeleria;
                }
            }
            catch
            {
                return listPapeleria;
            }
        }

        public bool createPapeleria(PapeleriaBLL papeleria)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Papeleria (Producto, Precio_compra, Precio_venta, Ganancia, Inventario) VALUES (@pro, @prec, @)prev, @gan, @inv;";
                    cmd.Parameters.AddWithValue("@pro", papeleria.Producto);
                    cmd.Parameters.AddWithValue("@prec", papeleria.Precio_compra);
                    cmd.Parameters.AddWithValue("@prev", papeleria.Precio_venta);
                    cmd.Parameters.AddWithValue("@gan", papeleria.Ganancia);
                    cmd.Parameters.AddWithValue("@inv", papeleria.Inventario);
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

        public bool updatePapeleria(PapeleriaBLL papeleria)
        {
            try
            { 
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "UPDATE Papeleria SET Producto = @pro, Precio_compra = @prc, Precio_venta = @prev, Ganancia = @gan, Inventario = @inv WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", papeleria.Id);
                    cmd.Parameters.AddWithValue("@pro", papeleria.Producto);
                    cmd.Parameters.AddWithValue("@prc", papeleria.Precio_compra);
                    cmd.Parameters.AddWithValue("@prv", papeleria.Precio_venta);
                    cmd.Parameters.AddWithValue("@gan", papeleria.Ganancia);
                    cmd.Parameters.AddWithValue("@inv", papeleria.inventario);
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

        public bool deletePapeleria(PapeleriaBLL papeleria)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Papeleria WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", papeleria.Id);
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
