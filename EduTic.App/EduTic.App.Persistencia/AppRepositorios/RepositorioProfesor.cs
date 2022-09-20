using EduTic.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;


namespace EduTic.App.Persistencia
{
    public class RepositorioProfesor:IRepositorioProfesor
    {
        private readonly AppContext _appContext=new AppContext();

        /* private readonly AppContext _appContext;

       public RepositorioProfesor(AppContext appContext)
       {
        _appContext=appContext;
       }  */

        public Profesor addProfesor(Profesor profesor)
        {
            var profesorAdicionada= _appContext.Profesor.Add(profesor);
           _appContext.SaveChanges();
           return profesorAdicionada.Entity;
        } 

        
        public IEnumerable<Profesor> GetAll()
        {
            return _appContext.Profesor;
        }

         public Profesor GetProfesorE(string email)
        {
            return _appContext.Profesor.FirstOrDefault(p=>p.email==email);
        }

        public Profesor update(Profesor profesor){
            var profesorEncontrado=_appContext.Profesor.FirstOrDefault(p=>p.id==profesor.id);
            if(profesorEncontrado!=null)
            {
                profesorEncontrado.nombres=profesor.nombres;
                profesorEncontrado.apellidos=profesor.apellidos;
                profesorEncontrado.email=profesor.email;
                profesorEncontrado.edad=profesor.edad;
                profesorEncontrado.direccion=profesor.direccion;
                profesorEncontrado.grado=profesor.grado;
                profesorEncontrado.cargo=profesor.cargo;
                profesorEncontrado.materiaP=profesor.materiaP;
               
                _appContext.SaveChanges();
            }
            return profesorEncontrado;
        } 
    }
}