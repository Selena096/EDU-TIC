using EduTic.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace EduTic.App.Persistencia
{
    public class RepositorioEstudiante:IRepositorioEstudiante
    {
        private readonly AppContext _appContext=new AppContext();

        public Estudiante addEstudiante(Estudiante estudiante)
        {
            var estudianteAdicionada= _appContext.Estudiante.Add(estudiante);
           _appContext.SaveChanges();
           return estudianteAdicionada.Entity;
        } 

         public Estudiante GetEstudianteE(string email)
        {
            return _appContext.Estudiante.FirstOrDefault(p=>p.email==email);
        }

        public Estudiante updateE(Estudiante estudiante){
            var estudianteEncontrado=_appContext.Estudiante.FirstOrDefault(p=>p.id==estudiante.id);
            if(estudianteEncontrado!=null)
            {
                estudianteEncontrado.nombres=estudiante.nombres;
                estudianteEncontrado.apellidos=estudiante.apellidos;
                estudianteEncontrado.email=estudiante.email;
                estudianteEncontrado.edad=estudiante.edad;
                estudianteEncontrado.direccion=estudiante.direccion;
                estudianteEncontrado.grado=estudiante.grado;
                estudianteEncontrado.codigoEstudiante=estudiante.codigoEstudiante;
                estudianteEncontrado.materiaE=estudiante.materiaE;
               
                _appContext.SaveChanges();
            }
            return estudianteEncontrado;
        } 

    }
}