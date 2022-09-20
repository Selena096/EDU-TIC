using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EduTic.App.Persistencia;
using EduTic.App.Dominio;
using Microsoft.AspNetCore.Authorization;


namespace EduTic.App.Presentacion.Pages
{
    [Authorize]
    public class Asignar_ActividadModel : PageModel
    {
        private readonly IRepositorioProfesor _repoProfesor;
        private readonly IRepositorioActividad _repoActividad;
        [BindProperty]
        public Profesor profesor{get;set;}
        public Actividad actividad{get;set;}

        public Asignar_ActividadModel(IRepositorioProfesor repoProfesor,IRepositorioActividad repoActividad)
        {
            _repoProfesor=repoProfesor;
            _repoActividad=repoActividad;
        }


        public void OnGet()
        {
            profesor=new Profesor();
        } 


        /* 
        public async Task<IActionResult> OnPost()
        {
            profesor=_repoProfesor.GetProfesorE(profesor.email);
            if (profesor == null)
            {
                Console.WriteLine("pesimo");
                return RedirectToPage("/Error");
            }
            return Page();
            Console.WriteLine("listo");
        } */

         public async Task<IActionResult> OnPostArchivo()
        {
            if (actividad==null)
            {
                Console.WriteLine("pesimo");
                return Page();
            }
            _repoActividad.addActividad(actividad);
            Console.WriteLine("listo");
             return RedirectToPage("/Profesor/Asignar_Actividad");
        }



    }
}
