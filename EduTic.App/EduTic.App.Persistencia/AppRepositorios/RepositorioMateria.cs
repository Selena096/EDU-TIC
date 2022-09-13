using EduTic.App.Dominio;
using System.Collections.Generic;

namespace EduTic.App.Persistencia
{
    public class RepositorioMateria:IRepositorioMateria
    {   
        //Conexion a la base de datos
        private readonly AppContext _appContext=new AppContext();
       
        public Materia addMateria(Materia materia)
        {
           var materiaAdicionada= _appContext.Materia.Add(materia);
           _appContext.SaveChanges();
           return materiaAdicionada.Entity;
        }

        public IEnumerable<Materia> GetAllMaterias()
        {
            return _appContext.Materia;
        }
    }
}