
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Tecnicos
    {
        private Conexion conexion = new Conexion();

        public DataTable ListarTecnicos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = "SELECT TecnicoID, Nombre, Especialidad FROM Tecnicos";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public void Insertar(string nombre, string especialidad)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = "INSERT INTO Tecnicos (Nombre, Especialidad) VALUES (@Nombre, @Especialidad)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Especialidad", especialidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Modificar(int tecnicoID, string nombre, string especialidad)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = "UPDATE Tecnicos SET Nombre = @Nombre, Especialidad = @Especialidad WHERE TecnicoID = @TecnicoID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TecnicoID", tecnicoID);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Especialidad", especialidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int tecnicoID)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = "DELETE FROM Tecnicos WHERE TecnicoID = @TecnicoID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TecnicoID", tecnicoID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}