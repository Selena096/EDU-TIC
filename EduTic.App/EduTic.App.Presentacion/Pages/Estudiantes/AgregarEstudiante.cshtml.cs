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
    public class AgregarEstudianteModel : PageModel
    {

         [BindProperty]
        public Estudiante estudiante{get;set;}
        private readonly IRepositorioEstudiante _repoEstudiante;

        public AgregarEstudianteModel(IRepositorioEstudiante repoEstudiante){
            _repoEstudiante=repoEstudiante;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            
            if(!ModelState.IsValid){
                return Page();
                Console.WriteLine("Valiste madres");
            }
            _repoEstudiante.addEstudiante(estudiante);
             Console.WriteLine("Agregado");
            return RedirectToPage("/Estudiantes/AgregarEstudiante");
        }

    }
}
