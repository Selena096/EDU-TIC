using System;

namespace EduTic.App.Dominio
{
    public class Estudiante:Persona{
        
        public string codigoEstudiante{get;set;}
        
          public Materia materiaE{get;set;}
        ///Relacion entre Estudiante y materia

    }
}