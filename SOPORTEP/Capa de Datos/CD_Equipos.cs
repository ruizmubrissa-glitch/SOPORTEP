using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Equipos
    {
        private Conexion conexion = new Conexion();

        public DataTable ListarEquipos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = "SELECT EquipoID, TipoEquipo, Modelo, UsuarioID FROM Equipos";
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

        public void Insertar(string tipoEquipo, string modelo, int usuarioID)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = "INSERT INTO Equipos (TipoEquipo, Modelo, UsuarioID) VALUES (@TipoEquipo, @Modelo, @UsuarioID)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TipoEquipo", tipoEquipo);
                    cmd.Parameters.AddWithValue("@Modelo", modelo);
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Modificar(int equipoID, string tipoEquipo, string modelo, int usuarioID)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = "UPDATE Equipos SET TipoEquipo = @TipoEquipo, Modelo = @Modelo, UsuarioID = @UsuarioID WHERE EquipoID = @EquipoID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EquipoID", equipoID);
                    cmd.Parameters.AddWithValue("@TipoEquipo", tipoEquipo);
                    cmd.Parameters.AddWithValue("@Modelo", modelo);
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int equipoID)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = "DELETE FROM Equipos WHERE EquipoID = @EquipoID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EquipoID", equipoID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}