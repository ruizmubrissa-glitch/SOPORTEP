using System;
using System.Data;
using CapaDatos;

namespace CapaLogica
{
    public class CL_Equipos
    {
        private CD_Equipos objetoCD = new CD_Equipos();

        public DataTable ObtenerEquipos()
        {
            return objetoCD.ListarEquipos();
        }

        public void InsertarEquipo(string tipoEquipo, string modelo, string usuarioIDStr)
        {
            if (string.IsNullOrWhiteSpace(tipoEquipo) || string.IsNullOrWhiteSpace(modelo))
            {
                throw new Exception("El tipo de equipo y el modelo son obligatorios.");
            }
            if (!int.TryParse(usuarioIDStr, out int usuarioID) || usuarioID <= 0)
            {
                throw new Exception("El ID de usuario debe ser un número válido.");
            }
            objetoCD.Insertar(tipoEquipo.Trim(), modelo.Trim(), usuarioID);
        }

        public void ActualizarEquipo(string idStr, string tipoEquipo, string modelo, string usuarioIDStr)
        {
            if (!int.TryParse(idStr, out int equipoID) || equipoID <= 0)
            {
                throw new Exception("Debe seleccionar un equipo válido para modificar.");
            }
            if (string.IsNullOrWhiteSpace(tipoEquipo) || string.IsNullOrWhiteSpace(modelo))
            {
                throw new Exception("El tipo de equipo y el modelo son obligatorios.");
            }
            if (!int.TryParse(usuarioIDStr, out int usuarioID) || usuarioID <= 0)
            {
                throw new Exception("El ID de usuario debe ser un número válido.");
            }
            objetoCD.Modificar(equipoID, tipoEquipo.Trim(), modelo.Trim(), usuarioID);
        }

        public void BorrarEquipo(string idStr)
        {
            if (!int.TryParse(idStr, out int equipoID) || equipoID <= 0)
            {
                throw new Exception("Debe seleccionar un equipo válido para eliminar.");
            }
            objetoCD.Eliminar(equipoID);
        }
    }
}