using Microsoft.EntityFrameworkCore;
using EduTic.App.Dominio;

namespace EduTic.App.Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Persona> Persona {get;set;}

        public DbSet<Profesor> Profesor {get;set;}

        public DbSet<Estudiante> Estudiante {get;set;}

        public DbSet<Materia> Materia {get;set;}

        public DbSet<Actividad> Actividad {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            ///Metodo para conexion a la base de datos

            if(!optionsBuilder.IsConfigured){ ///Nombre al servidor
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-9KMQMLU;Initial Catalog= EduT; Integrated Security=True");
            }

        }

    }
}