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
    public class Asignar_ActividadModel : PageModel
    {

        private readonly IRepositorioMateria _repoMateria;
        public IEnumerable<Materia> listaMateria{get;set;}

        public Asignar_ActividadModel(IRepositorioMateria repoMateria)
        {
            _repoMateria=repoMateria;
        }


        public void OnGet()
        {
            listaMateria=new List<Materia>();
            listaMateria =_repoMateria.GetAllMaterias();
        }
    }
}
