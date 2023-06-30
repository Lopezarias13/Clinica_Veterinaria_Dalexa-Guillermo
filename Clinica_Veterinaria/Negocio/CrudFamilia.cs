using Clinica_Veterinaria.Datos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Veterinaria.Negocio
{
    internal class CrudFamilia
    {
        //Intacia de la base de datos
        public static ClinicaVeterinariaContainer db = new ClinicaVeterinariaContainer();

        //Metodo Listar Familia ingresados en la base de datos
        public static List<Familia> ListarFamilia()
        {
            return db.Familia.ToList();
        }
        //Metodo para agregar un nuevo familia
        public static int AgregarFamilia(Familia F)
        {
            db.Familia.Add(F);
            return db.SaveChanges();
        }
        //Metodo para buscar un familia por su id
        public static Familia BuscarFamilia(int id)
        {
            return db.Familia.Find(id);
        }
        //Metodo para editar un familia
        public static int EditarFAMILIA(Familia F)
        {
            db.Entry(F).State = EntityState.Modified;
            return db.SaveChanges();
        }
        //Metodo para eliminar un familia
        public static int EliminarFamilia(int id)
        {
            Familia AEliminar = BuscarFamilia(id);
            db.Familia.Remove(AEliminar);
            return db.SaveChanges();
        }
    }
}
