using EduTic.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Microsoft.AspNetCore.Mvc.Rendering; 

namespace EduTic.App.Persistencia
{
    public class RepositorioMateria:IRepositorioMateria
    {   
        //Conexion a la base de datos
        private readonly AppContext _appContext=new AppContext();
       /* private readonly AppContext _appContext;

       public RepositorioMateria(AppContext appContext)
       {
        _appContext=appContext;
       } */

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

         public List<SelectListItem> ConsultarNombresMateria()
        {
            return _appContext.Materia.Select(m=> new SelectListItem{
                Value=(m.nombre).ToString(),
                Text=(m.nombre +" "+ m.id)
            }).ToList();
        } 


        /* public Materia ConsultarxNombre(string nombre)
        {
           return _appContext.Materia.FirstOrDefault(m=>m.nombre==nombre);
        } */

         public Materia GetxCodigo(int c)
        {
           return _appContext.Materia.FirstOrDefault(p=>p.id==c);
        }
    }   
} 