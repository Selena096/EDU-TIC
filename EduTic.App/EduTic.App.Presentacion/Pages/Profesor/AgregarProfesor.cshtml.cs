using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EduTic.App.Dominio;
using EduTic.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace EduTic.App.Presentacion.Pages
{
    [Authorize]
    public class AgregarProfesorModel : PageModel
    {
        [BindProperty]
        public Profesor profesor{get;set;}
        private readonly IRepositorioProfesor _repoProfesor;
       
        //public Profesor profesor{get;set;}
        
        

        public AgregarProfesorModel(IRepositorioProfesor repoProfesor)
        {
            _repoProfesor=repoProfesor;
        }

        public void OnGet()
        {
        }

         public async Task<IActionResult> OnPost()
        {
            Console.WriteLine(profesor);
            if(!ModelState.IsValid){
                return Page();
                Console.WriteLine("Valiste madres");
            }
            _repoProfesor.addProfesor(profesor);
             Console.WriteLine("Agregado");
            return RedirectToPage("/Profesor/AgregarProfesor");
        }

    }
}
