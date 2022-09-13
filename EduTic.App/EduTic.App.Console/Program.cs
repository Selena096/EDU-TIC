using System;
using EduTic.App.Dominio;
using EduTic.App.Persistencia;

namespace EduTic.App.Console
{
    class Program
    {
        private static IRepositorioMateria _repoMateria= new RepositorioMateria(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            AgregarMateria();
        }

        private static void AgregarMateria()
        {
            var materia= new Materia //construyendo un objeto
            {
                nombre="Ingles"
               
            };
            _repoMateria.addMateria(materia);
        }

    }
}
