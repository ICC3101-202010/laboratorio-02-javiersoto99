﻿using System;
using System.Collections.Generic;

namespace lab2
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            var listadecanciones = new Espotifai();
            int funcion = 0;
            Console.WriteLine("Hola! Bienvenido a Espotifai!");

            while (funcion != 3)
            {
                Console.WriteLine("Elija una funcion: ");
                
                Console.WriteLine("1.- Agregar Cancion ");
                Console.WriteLine("2.- Ver Canciones");
                Console.WriteLine("3.- Salir del Programa");
                Console.WriteLine("4.- Ver Canciones por Criterio");
                Console.WriteLine("5.- Generar Playlist");
                Console.WriteLine("6.- Ver Playlist");
                funcion = Convert.ToInt32(Console.ReadLine());


                if (funcion == 1 || funcion == 2 || funcion == 3 || funcion == 4 || funcion == 5 || funcion == 6)
                {
                    if (funcion == 1)
                    {
                        Console.WriteLine("Ingrese genero: ");
                        string generocan = Console.ReadLine();
                        Console.WriteLine("Ingrese artista: ");
                        string artistacan = Console.ReadLine();
                        Console.WriteLine("Ingrese album: ");
                        string albumcan = Console.ReadLine();
                        Console.WriteLine("Ingrese nombre: ");
                        string nombrecan = Console.ReadLine();

                        

                        var cancion = new Cancion(nombrecan, albumcan, artistacan, generocan);
                        listadecanciones.AgregarCancion(cancion);
                       

                    }
                    else if (funcion == 2)
                    {
                        listadecanciones.VerCanciones();
                    }
                    else if (funcion == 3)
                    {
                        Console.WriteLine("Cerrando programa... Hasta la proxima!");
                    }
                    else if (funcion == 4)
                    {
                        
                       
                        Console.WriteLine("Ingrese criterio: ");
                        string criterio = Console.ReadLine();
                        Console.WriteLine("Ingrese valor del criterio: ");
                        string valor = Console.ReadLine();

                        List<Cancion> listaquecumple = listadecanciones.CancionesPorCriterio(criterio, valor);

                        for (int a = 0; a < listaquecumple.Count ; a ++)
                        {
                            Console.WriteLine(listaquecumple[a].Informacion());
                        }

                    }
                    else if (funcion == 5)
                    {
                        Console.WriteLine("Ingrese Criterio para la Playlist: ");
                        string criterioplaylist = Console.ReadLine();
                        Console.WriteLine("Ingrese el Valor del Criterio para la Playlist: ");
                        string valorcriterioplaylist = Console.ReadLine();
                        Console.WriteLine("Ingrese nombre para la Playlist: ");
                        string nombreplaylist = Console.ReadLine();

                        listadecanciones.GenerarPlaylist(criterioplaylist, valorcriterioplaylist, nombreplaylist);
                    }
                    else if (funcion == 6)
                    {
                        listadecanciones.VerMisPlaylists();
                    }
                }
                else
                {
                    Console.WriteLine("Funcion invalida... intentelo de nuevo");
                    
                }



            }

            


           
            
     


        }
    }
}
