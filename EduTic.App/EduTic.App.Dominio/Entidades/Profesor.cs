using System;

namespace EduTic.App.Dominio
{
    public class Profesor:Persona{
        
        public string cargo{get;set;}
        
        //public Materia materiaPid{get;set;}
        ///Relacion entre Profesor y materia
        public Materia materiaP{get;set;}

    }
}