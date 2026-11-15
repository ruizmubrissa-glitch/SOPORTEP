using System;
using System.Data;
using CapaDatos;

namespace CapaLogica
{
    public class CL_Tecnicos
    {
        private CD_Tecnicos objetoCD = new CD_Tecnicos();

        public DataTable ObtenerTecnicos()
        {
            return objetoCD.ListarTecnicos();
        }

        public void InsertarTecnico(string nombre, string especialidad)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(especialidad))
            {
                throw new Exception("Todos los campos del técnico son obligatorios.");
            }
            objetoCD.Insertar(nombre.Trim(), especialidad.Trim());
        }

        public void ActualizarTecnico(string idStr, string nombre, string especialidad)
        {
            if (!int.TryParse(idStr, out int tecnicoID) || tecnicoID <= 0)
            {
                throw new Exception("Debe seleccionar un técnico válido para modificar.");
            }
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(especialidad))
            {
                throw new Exception("El nombre y la especialidad no pueden estar vacíos.");
            }
            objetoCD.Modificar(tecnicoID, nombre.Trim(), especialidad.Trim());
        }

        public void BorrarTecnico(string idStr)
        {
            if (!int.TryParse(idStr, out int tecnicoID) || tecnicoID <= 0)
            {
                throw new Exception("Debe seleccionar un técnico válido para eliminar.");
            }
            objetoCD.Eliminar(tecnicoID);
        }
    }
}