using EduTic.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Data;


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
    }
}