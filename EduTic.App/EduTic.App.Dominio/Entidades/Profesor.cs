using System;

namespace EduTic.App.Dominio
{
    public class Profesor:Persona{
        
        public String cargo{get;set;}
        
        public Materia Materia{get;set;}
        ///Relacion entre Profesor y materia

    }
}