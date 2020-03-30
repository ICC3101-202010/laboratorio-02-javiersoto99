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

        public List<Cancion> CancionesPorCriterio(String criterio, String valor)
        {
            List<Cancion> cumple = new List<Cancion>();
            if (criterio == "genero" || criterio == "artista" || criterio == "album" || criterio == "nombre")
            {
                for (int k = 0; k < listacanciones.Count(); k++)
                {
                    if (criterio == "genero")
                    {
                        if (valor == listacanciones[k].Genero)
                        {
                            cumple.Add(listacanciones[k]);
                            return cumple;
                        }
                        else
                        {
                            Console.WriteLine("No se han encontrado canciones con el valor solicitado");
                        }
                    }
                    else if(criterio == "album")
                    {
                        if (valor == listacanciones[k].Album)
                        {
                            cumple.Add(listacanciones[k]);
                            return cumple;
                        }
                        else
                        {
                            Console.WriteLine("No se han encontrado canciones con el valor solicitado");
                        }
                    }
                    else if(criterio == "artista")
                    {
                        if(valor == listacanciones[k].Artista)
                        {
                            cumple.Add(listacanciones[k]);
                            return cumple;
                        }
                        else
                        {
                            Console.WriteLine("No se han encontrado canciones con el valor solicitado");
                        }
                    }
                    else if (criterio == "nombre")
                    {
                        if(valor == listacanciones[k].Nombre)
                        {
                            cumple.Add(listacanciones[k]);
                            return cumple;

                        }
                        else
                        {
                            Console.WriteLine("No se han encontrado canciones con el valor solicitado");
                            return cumple;
                        }
                    }

                }
            }
            else
            {
                Console.WriteLine("Criterio invalido");
                
            }
            return cumple;

            
            
            
            
                
             
        }



    }
}
