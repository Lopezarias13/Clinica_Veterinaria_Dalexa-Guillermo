namespace Clinica_Veterinaria.Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class ClinicaVeterinariaContainer : DbContext
    {
        public ClinicaVeterinariaContainer()
            : base("name=ClinicaVeterinariaContainer")
        {
        }

        public object Paciente { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        //Bitacora, Familia, HistorialMedico, Persona, Usuario, Paciente, Vacuna
        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<Familia> Familia { get; set; }
        public virtual DbSet<HistorialMedico> HistorialMedico { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<Vacuna> Vacuna { get; set; }

    }
   }

