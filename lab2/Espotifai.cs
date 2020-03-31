using System;
using System.Collections.Generic;
using System.Linq;

namespace lab2
{
    public class Espotifai
    {
        List<Cancion> listacanciones = new List<Cancion>();
        List<Playlist> listaplaylist2 = new List<Playlist>();

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
                if (criterio == "genero")
                {
                    for (int k = 0; k < listacanciones.Count(); k++)
                    {
                        if (valor == listacanciones[k].Genero)
                        {
                            cumple.Add(listacanciones[k]);
                            return cumple;
                        }
                    }
                        

                }
                else if (criterio == "album")
                {
                    for (int k = 0; k < listacanciones.Count(); k++)
                    {
                        if (valor == listacanciones[k].Album)
                        {
                            cumple.Add(listacanciones[k]);
                            return cumple;
                        }
                    }

                        

                }
                else if (criterio == "artista")
                {
                    for (int k = 0; k < listacanciones.Count(); k++)
                    {
                        if (valor == listacanciones[k].Artista)
                        {
                            cumple.Add(listacanciones[k]);
                            return cumple;
                        }
                    }

                        

                }
                else if (criterio == "nombre")
                {
                    for (int k = 0; k < listacanciones.Count(); k++)
                    {
                        if (valor == listacanciones[k].Nombre)
                        {
                            cumple.Add(listacanciones[k]);
                            return cumple;

                        }
                    }
                                     

                }

                if (cumple.Count == 0)
                {
                    Console.WriteLine("No se han encontrado canciones con el valor solicitado");
                    return cumple;
                }



            }
            else
            {
                Console.WriteLine("Criterio invalido");
                
            }
            return cumple;



        }

        public bool GenerarPlaylist(String criterioPlay, String valorCriterioPlay, String nombrePlay)
        {
            var playlist = new Playlist(nombrePlay);
            
            foreach(Playlist b in listaplaylist2)
            {
                if(b.Nombreplaylist == nombrePlay)
                {
                    Console.WriteLine("Ya tiene una Playlist con el mismo nombre");
                    return false;
                }
            }
            foreach(Cancion x in CancionesPorCriterio(criterioPlay, valorCriterioPlay ))
            {
                playlist.listaplaylist.Add(x);

            }
            listaplaylist2.Add(playlist);
            return true;

            


            
        }

        public String VerMisPlaylists()
        {
            for(int a = 0; a < listaplaylist2.Count; a++)
            {
                listaplaylist2[a].Informacion();
                

            }
            return ".";
        }

    }
}
