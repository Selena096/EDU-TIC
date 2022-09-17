/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EduTic.App.Persistencia;
using EduTic.App.Dominio;

namespace EduTic.App.Presentacion.Pages
{
    public class AsignarCargaAModel : PageModel
    
    {

        private readonly IRepositorioPersona _repoPersona;
        public Persona Persona{get;set;}
        public IEnumerable<Persona> listaPersona{get;set;}


        public AsignarCargaModel(IRepositorioPersona repoPersona)
        {   
            _repoPersona=repoPersona;
        }

        public void OnGet(int personaId)
        {
            persona = _repoPersona.GetPersona(personaId);
            listaPersona=new List<Persona>();
            listaPersona =_repoPersona.GetAllPersona();
            

        }
    }
}
 */