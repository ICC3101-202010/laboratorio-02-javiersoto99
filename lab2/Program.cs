using System;

namespace lab2
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            var cancion1 = new Cancion("Sofia", "Immunity", "Clairo", "Alternativa");
            Console.WriteLine(cancion1.Informacion());
        }
    }
}
