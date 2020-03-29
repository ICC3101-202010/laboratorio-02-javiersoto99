using System;
using System.Collections.Generic;
using System.Linq;

namespace lab2
{
    public class Espotifai
    {
        List<Cancion> listacanciones = new List<Cancion>();

        public Espotifai()
        {

        }

        public bool AgregarCancion(Cancion cancion)
        {
            foreach (Cancion i in listacanciones)
            {
                if (i.Informacion() == cancion.Informacion())
                    return false;
            }
            listacanciones.Add(cancion);
            return true;

        }

        public void VerCanciones()
        {
            if (listacanciones.Count() == 0)
            {
                Console.WriteLine("Por el momento no tienes canciones... agrega canciones con la funcion 1!");
            }
            else
            {
                Console.WriteLine("Sus canciones son: ");
                foreach(Cancion j in listacanciones)
                {
                    Console.WriteLine(j.Informacion());
                }
            }
        }



    }
}
