using EduTic.App.Dominio;
using System.Collections.Generic;
using System;
using System.IO;

namespace EduTic.App.Persistencia
{
    public class RepositorioActividad: IRepositorioActividad
    {
        private readonly AppContext _appContext=new AppContext();
 
        public Actividad addActividad(Actividad actividad)
        {
           
                /* byte[] bytes;
                using(BinaryReader br = new BinaryReader(actividad.archivoP))
                {
                    bytes= br.ReadBytes(actividad.archivoP);
                } */

                    /* Actividad d = new Actividad();
                    d.nombreActividad=Actividad.nombreActividad;
                    d.descripcion=Actividad.descripcion;
                    d.archivoP=Actividad.archivoP; */
                   var actividadAdicionada = _appContext.Actividad.Add(actividad);
                    _appContext.SaveChanges();
                    return actividadAdicionada.Entity; 
               
            
            /* byte[] archivo = null; 
            Stream MyStream = actividad.archivoP.OpenFile();
            MemoryStream obj= new MemoryStream();
            MyStream.CopyTo(obj);
            archivoP=obj.ToArray(); 
 */
            
 
        }  

         public IEnumerable<Actividad> GetAllActividad()
        {
            return _appContext.Actividad;
        } 

        
      
    }
} 