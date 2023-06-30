using Clinica_Veterinaria.Datos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Veterinaria.Negocio
{
    internal class CrudHM//Historial Medico
    {
        //Intacia de la base de datos
        public static ClinicaVeterinariaContainer db = new ClinicaVeterinariaContainer();

        //Metodo Listar HM ingresados en la base de datos
        public static List<HistorialMedico> ListarPacientes()
        {
            return db.HistorialMedico.ToList();
        }
        //Metodo para agregar un nuevo HM
        public static int AgregarHM(HistorialMedico hm)
        {
            db.HistorialMedico.Add(hm);
            return db.SaveChanges();
        }
        //Metodo para buscar un hm por su id
        public static HistorialMedico BuscarHM(int id)
        {
            return db.HistorialMedico.Find(id);
        }
        //Metodo para editar un Historial Medico
        public static int EditarHM(HistorialMedico hm)
        { 
            db.Entry(hm).State = EntityState.Modified;
            return db.SaveChanges();
        }
        //Metodo para eliminar un HM
        public static int EliminarHM(int id)
        {
            HistorialMedico AEliminar = BuscarHM(id);
            db.HistorialMedico.Remove(AEliminar);
            return db.SaveChanges();
        }
    }
}
