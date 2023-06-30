using Clinica_Veterinaria.Datos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Veterinaria.Negocio
{
    internal class CrudPersona
    {
        //Intacia de la base de datos
        public static ClinicaVeterinariaContainer db = new ClinicaVeterinariaContainer();

        //Metodo Listar Persona ingresados en la base de datos
        public static List<Persona> ListarPersona()
        {
            return db.Persona.ToList();
        }   
        //Metodo para agregar un nuevo persona
        public static int AgregarPersona(Persona P)
        {
            db.Persona.Add(P);
            return db.SaveChanges();
        }
        //Metodo para buscar un persona por su id
        public static Persona BuscarPersona(int id)
        {
            return db.Persona.Find(id);
        }
        //Metodo para editar un persona
        public static int EditarPersona(Persona P)
        {
            db.Entry(P).State = EntityState.Modified;
            return db.SaveChanges();
        }
        //Metodo para eliminar un persona
        public static int EliminarPersona(int id)
        {
            Persona AEliminar = BuscarPersona(id);
            db.Persona.Remove(AEliminar);
            return db.SaveChanges();
        }
    }
}
