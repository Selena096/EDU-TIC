using EduTic.App.Dominio;
using System.Collections.Generic;


namespace EduTic.App.Persistencia
{

    public interface IRepositorioMateria
    {
         Materia addMateria(Materia materia); // Crear una materia
         IEnumerable<Materia> GetAllMaterias();
        //Listas 
    }
   
}