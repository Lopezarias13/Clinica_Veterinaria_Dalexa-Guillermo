using Clinica_Veterinaria.Datos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Veterinaria.Negocio
{
    internal class CrudUsuario
    {
        //Intacia de la base de datos
        public static ClinicaVeterinariaContainer db = new ClinicaVeterinariaContainer();

        //Metodo Listar Pacientes ingresados en la base de datos
        public static List<Usuario> ListarUsuario()
        {
            return db.Usuario.ToList();
        }
        //Metodo para agregar un nuevo usuario
        public static int AgregarUsuario(Usuario U)
        {
            db.Usuario.Add(U);
            return db.SaveChanges();
        }
        //Metodo para buscar un usuario por su id
        public static Usuario BuscarUsuario(int id)
        {
            return db.Usuario.Find(id);
        }
        //Metodo para editar un usuario
        public static int EditarUsuario(Usuario U)
        {
            db.Entry(U).State = EntityState.Modified;
            return db.SaveChanges();
        }
        //Metodo para eliminar un paciente
        public static int EliminarUsuario(int id)
        {
            Usuario AEliminar = BuscarUsuario(id);
            db.Usuario.Remove(AEliminar);
            return db.SaveChanges();
        }
    }
}
