using System;
using EduTic.App.Dominio;
using EduTic.App.Persistencia;

namespace EduTic.App.Console
{
    class Program
    {
        //private static IRepositorioMateria _repoMateria= new RepositorioMateria(new Persistencia.AppContext());
        private static IRepositorioProfesor _repoProfesor= new RepositorioProfesor(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            AgregarProfesor();
        }

         /* private static void AgregarMateria()
        {
            var materia= new Materia //construyendo un objeto
            {
                nombre="Ciencias"
               
            };
            _repoMateria.addMateria(materia);
        }  */

        private static void AgregarProfesor()
        {
            var profesor= new Profesor //construyendo un objeto
            {
                nombres="Selena",
                apellidos="Rivera",
                email="sele@gmail.com",
                edad=45,
                direccion="jsdsjd",
                nombreUsuario="hdjshdjsd",
                grado="Sexto",
                cargo="Primaria"
               
            };
            _repoProfesor.addProfesor(profesor);
        } 

    }
}
