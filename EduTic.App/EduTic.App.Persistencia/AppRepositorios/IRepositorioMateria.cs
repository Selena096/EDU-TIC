using EduTic.App.Dominio;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering; 

namespace EduTic.App.Persistencia
{

    public interface IRepositorioMateria
    {
         Materia addMateria(Materia materia); // Crear una materia
         IEnumerable<Materia> GetAllMaterias();
        //Listas 
       /*  List<SelectListItem> ConsultarNombresMateria(); */
        List<SelectListItem> ConsultarNombresMateria();
        Materia ConsultarxNombre(string nombre);
        Materia GetxCodigo(int id);
    }
   
} 