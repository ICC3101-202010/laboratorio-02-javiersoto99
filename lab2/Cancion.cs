namespace lab2
{
    public class Cancion
    {
        public string Nombre;
        public string Album;
        public string Artista;
        public string Genero;

        public Cancion(string nombre, string album, string artista, string genero)
        {
            this.Nombre = nombre;
            this.Album = album;
            this.Artista = artista;
            this.Genero = genero;


        }

        public string Informacion()
        {
            string Info = ("Genero:" +  Genero + ", Artista:" + Artista+ ", Album:" + Album + ", Nombre:" + Nombre+"\n");
            return Info;
        }

    }


}
