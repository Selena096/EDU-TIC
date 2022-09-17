using EduTic.App.Dominio;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EduTic.App.Persistencia
{   
    public interface IRepositorioProfesor
    {
        Profesor addProfesor(Profesor profesor);
        IEnumerable<Profesor> GetAll();
        
        

    }
}