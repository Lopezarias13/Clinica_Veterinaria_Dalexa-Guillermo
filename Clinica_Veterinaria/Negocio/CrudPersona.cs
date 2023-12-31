﻿using Clinica_Veterinaria.Datos;
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
        //CrudPersona.cs
        //Intacia de la base de datos
        public static ClinicaVeterinariaContainer db = new ClinicaVeterinariaContainer();

        //Metodo Listar Persona ingresados en la base de datos
        public static List<Persona> ListarPersona()// Listar todos los persona , CRUD: Read
        {
            return db.Personas.ToList();
        }   
        //Metodo para agregar un nuevo persona
        public static int AgregarPersona(Persona P)// Crear un nuevo persona
        {
            db.Personas.Add(P);
            return db.SaveChanges();
        }
        //Metodo para buscar un persona por su id
        public static Persona BuscarPersona(int id)//
        {
            return db.Personas.Find(id);
        }
        //Metodo para buscar un persona por su nombre
        public static Persona BuscarPersonaNombre(string nombre)//
        {
            return db.Personas.FirstOrDefault(p => p.Nombre == nombre);
        }
        //Metodo para editar un persona
        public static int EditarPersona(Persona P)//Modificar un persona
        {
            db.Entry(P).State = EntityState.Modified;
            return db.SaveChanges();
        }
        //Metodo para eliminar un persona
        public static int EliminarPersona(int id)//Eliminar un persona
        {
            Persona AEliminar = BuscarPersona(id);
            db.Personas.Remove(AEliminar);
            return db.SaveChanges();
        }
    }
}
