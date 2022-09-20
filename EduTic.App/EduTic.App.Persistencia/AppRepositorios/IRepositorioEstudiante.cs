using EduTic.App.Dominio;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EduTic.App.Persistencia
{   
    public interface IRepositorioEstudiante
    {
        Estudiante addEstudiante(Estudiante estudiante);
        Estudiante GetEstudianteE(string email);
        Estudiante updateE(Estudiante estudiante);
        
        
    }
}