using EduTic.App.Dominio;
using System.Collections.Generic;

namespace EduTic.App.Persistencia
{
    public interface IRepositorioActividad
    {
        Actividad addActividad(Actividad actividad); 
        IEnumerable<Actividad> GetAllActividad(); //Listar Actividades


    }
} 