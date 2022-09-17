using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EduTic.App.Persistencia;
using EduTic.App.Dominio;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace EduTic.App.Presentacion.Pages
{
    public class formularioPersonaModel : PageModel
    {
        private readonly IRepositorioProfesor _repoProfesor;
        private readonly IRepositorioMateria _repoMateria;
        [BindProperty]
        public Profesor Profesor{get;set;}
        public Materia Materia{get;set;}
        
        public List<SelectListItem> nombreMateria{get;set;} 
        /* public List<SelectListItem> nombreMateria{get;set;} */
        
        //public IEnumerable<Profesor> lista{get;set;}
        

        public formularioPersonaModel(IRepositorioProfesor repoProfesor,IRepositorioMateria repoMateria)
        {
            _repoProfesor=repoProfesor;
            _repoMateria=repoMateria;
        }

        public void OnGet()///enviar elementos
        {
            Profesor=new Profesor();
            Materia= new Materia();
            nombreMateria =_repoMateria.ConsultarNombresMateria();
           
        }

        public async Task<IActionResult> OnPost()
        {
           //Console.WriteLine(Profesor.cargo);
           string dato=Request.Form["nombres"];
           Console.WriteLine(dato);
           Profesor.Materia=Materia;
           Profesor= _repoProfesor.addProfesor(Profesor);
            if(!ModelState.IsValid){
                return Page();
            }
            return RedirectToPage("/Index");
        }

    }
}