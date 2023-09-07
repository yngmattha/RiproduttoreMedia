using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RiproduttoreMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Menu.StartMenu();
            string b = Console.ReadLine();
            List<Content> listaContenuti = new List<Content>();

            List<Song> listaSongs = new List<Song>
            {
                new Song() { _nome = "starboy" },
                new Song() { _nome = "blinding lights" },
                new Song() { _nome = "take my breath" },
                new Song() { _nome = "after hours" }
            };

            List<Movie> listaMovies = new List<Movie>
            {
                new Movie() { _nome = "interstellar" },
                new Movie() { _nome = "the wolf of wall street" },
                new Movie() { _nome = "oppenheimer" },
                new Movie() { _nome = "cars" }
            };
            if(b == "V")
            {
                listaContenuti = listaSongs.Cast<Content>().ToList();

            }
            else
            {
                listaContenuti = listaMovies.Cast<Content>().ToList();
            }
            listaContenuti.ToString();
            
            
            
         
            


        }
    }
}
