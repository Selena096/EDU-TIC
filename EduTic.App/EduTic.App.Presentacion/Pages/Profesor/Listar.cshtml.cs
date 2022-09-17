using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EduTic.App.Persistencia;
using EduTic.App.Dominio;

namespace EduTic.App.Presentacion.Pages
{
    public class ListarModel : PageModel
    {
        private readonly IRepositorioActividad _repoActividad;
        public IEnumerable<Actividad> listaActividad{get;set;}

        public ListarModel(IRepositorioActividad repoActividad)
        {
            _repoActividad=repoActividad;
        }
        
        public void OnGet()
        {
            listaActividad=new List<Actividad>();
            listaActividad =_repoActividad.GetAllActividad();
            
            
        }
    }
}