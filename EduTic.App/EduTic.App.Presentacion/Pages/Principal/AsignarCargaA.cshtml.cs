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
    public class AsignarCargaAModel : PageModel
    
    {
        
        private readonly IRepositorioProfesor _repoProfesor;
        private readonly IRepositorioMateria _repoMateria;
        [BindProperty]
        public Profesor profesor{get;set;}
        public Materia materiaP{get;set;}
        public List<SelectListItem> nombreMateria{get;set;} 
         /* [BindProperty] */
         
        public AsignarCargaAModel(IRepositorioProfesor repoProfesor,IRepositorioMateria repoMateria)
        {   
             _repoProfesor=repoProfesor;
             _repoMateria=repoMateria;
        }

        public void OnGet()
        {
            profesor=new Profesor();
            nombreMateria =_repoMateria.ConsultarNombresMateria();
        }


        public async Task<IActionResult> OnPost()
        {
            string dato = Request.Form["nombres"];
            Console.WriteLine(dato);
            profesor = _repoProfesor.GetProfesorE(profesor.email);
            nombreMateria =_repoMateria.ConsultarNombresMateria();
            if (profesor == null)
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
            materiaP=_repoMateria.GetxCodigo(c);
            profesor.materiaP=materiaP;
            profesor=_repoProfesor.update(profesor);
            if(profesor == null){
                return RedirectToPage("/Error");
            } 
            return RedirectToPage("/Principal/AsignarCargaA"); 
            
        }

    }
}
