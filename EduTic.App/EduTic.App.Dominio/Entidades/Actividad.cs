using System;

namespace EduTic.App.Dominio{

    public class Actividad{

        public int id{get;set;}
        public String nombreActividad{get;set;}
        public String descripcion{get;set;}
        public float nota{get;set;}
        public byte[] archivoP{get;set;}
        public byte[] archivoE{get;set;} 
        public Materia materias{get;set;}
        ///Relacion de actividad con materia
        

    }
}