using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_Milagro_De_La_Paz.DAL
{
    public class EmpleadosDaLL
    {
        private Database db;
        public EmpleadosDaLL()
        {
            db = new Database();
        }

        public DataTable getAllSedes()
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

        public List<EmpleadosBLL> getAllSedess()
        {
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Empleados";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSedes.Add(new EmpleadosBLL(
                                Convert.ToInt32(reader["id"]),
                                Convert.ToString(reader["nombre"]),
                                Convert.ToString(reader["ubicacion"])
                                Convert.ToString(reader["ubicacion"])
                                Convert.ToString(reader["ubicacion"])
                            ));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron registros.");
                    }
                    con.Close();
                    return listSedes;
                }
            }
            catch
            {
                return listSedes;
            }
        }

        public bool createSede(SedesBLL sede)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Sedes (nombre, ubicacion) VALUES (@nom, @ub);";
                    cmd.Parameters.AddWithValue("@nom", sede.Nombre);
                    cmd.Parameters.AddWithValue("@ub", sede.Ubicacion);
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

        public bool updateSede(SedesBLL sede)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "UPDATE Sedes SET nombre = @nom, ubicacion = @ub WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", sede.Id);
                    cmd.Parameters.AddWithValue("@nom", sede.Nombre);
                    cmd.Parameters.AddWithValue("@ub", sede.Ubicacion);
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

        public bool deleteSede(SedesBLL sede)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Sedes WHERE id = @id;";
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
