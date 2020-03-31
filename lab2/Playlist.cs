using System;
using System.Collections.Generic;

namespace lab2
{
    public class Playlist
    {
        public string Nombreplaylist;
        public List<Cancion> listaplaylist = new List<Cancion>();


        public Playlist(string nombreplaylist)
        {
            this.Nombreplaylist = nombreplaylist;
        }

        public void Informacion()
        {
            Console.WriteLine("Nombre Playlist:" + Nombreplaylist);
            Console.WriteLine(listaplaylist.Count + "  canciones: ");

            foreach(Cancion i in listaplaylist)
            {
                Console.WriteLine(i.Informacion());
            }

        }
    }
}
