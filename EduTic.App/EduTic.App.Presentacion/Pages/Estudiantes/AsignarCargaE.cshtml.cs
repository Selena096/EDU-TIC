using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EduTic.App.Dominio;
using EduTic.App.Persistencia;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace EduTic.App.Presentacion.Pages
{
    [Authorize]
    public class AsignarCargaEModel : PageModel
    {

        private readonly IRepositorioEstudiante _repoEstudiante;
        private readonly IRepositorioMateria _repoMateria;
        [BindProperty]
        public Estudiante estudiante{get;set;}
        public Materia materiaE{get;set;}
        public List<SelectListItem> nombreMateria{get;set;} 

        public AsignarCargaEModel(IRepositorioEstudiante repoEstudiante,IRepositorioMateria repoMateria)
        {   
             _repoEstudiante=repoEstudiante;
             _repoMateria=repoMateria;
        }

        public void OnGet()
        {
           estudiante=new Estudiante();
           nombreMateria =_repoMateria.ConsultarNombresMateria();
        }

         public async Task<IActionResult> OnPost()
        {
            string dato = Request.Form["nombres"];
            Console.WriteLine(dato);
            estudiante = _repoEstudiante.GetEstudianteE(estudiante.email);
            nombreMateria =_repoMateria.ConsultarNombresMateria();
            if (estudiante == null)
            {
                Console.WriteLine("pesimo");
                return RedirectToPage("/Error");
            }
            return Page();
            Console.WriteLine("listo");
        }

        public async Task<IActionResult> OnPostEdit()
        {
             //Console.WriteLine(Profesor.cargo);
            nombreMateria=_repoMateria.ConsultarNombresMateria();
            string dato=Request.Form["nombres"];
            var r=dato.Split(" ");
            //Console.WriteLine(r[1]);
            string l=(r[1]);
            int c=Int32.Parse(l);
            Console.WriteLine(c);
            materiaE=_repoMateria.GetxCodigo(c);
            estudiante.materiaE=materiaE;
            estudiante=_repoEstudiante.updateE(estudiante);
            if(estudiante == null){
                return RedirectToPage("/Error");
            } 
            return RedirectToPage("/Principal/AsignarCargaA"); 
            
        }
    }
}
