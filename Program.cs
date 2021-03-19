using System;
using System.Collections.Generic;

namespace TC5_Peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombresDePelicula = new List<string>();
            nombresDePelicula.Add("Toy Story");
            nombresDePelicula.Add("Avengers");
            nombresDePelicula.Add("Bicentennial Man");
            nombresDePelicula.Add("Beetlejuice");
            nombresDePelicula.Add("Silence of the Lambs");
            nombresDePelicula.Add("Bad Boys");
            nombresDePelicula.Add("Bad Boys");
            nombresDePelicula.Add("Aladdin");
            nombresDePelicula.Add("Aladdin");

            // No permite elementos duplicados
            HashSet<string> nombresDePeliculaSet = new HashSet<string>();
            nombresDePeliculaSet.Add("Toy Story");
            nombresDePeliculaSet.Add("Avengers");
            nombresDePeliculaSet.Add("Bicentennial Man");
            nombresDePeliculaSet.Add("Beetlejuice");
            nombresDePeliculaSet.Add("Silence of the Lambs");
            nombresDePeliculaSet.Add("Bad Boys");
            nombresDePeliculaSet.Add("Bad Boys");
            nombresDePeliculaSet.Add("Aladdin");
            nombresDePeliculaSet.Add("Aladdin");

            Console.WriteLine("Cant. de películas en nombresDePelicula: " + nombresDePelicula.Count);
            Console.WriteLine("Cant. de películas en nombresDePeliculaSet: " + nombresDePeliculaSet.Count);
            // HashSet o Set no permite duplicados, las listas si 

            HashSet<TC5_Peliculas> peliculasSet = new HashSet<TC5_Peliculas>();
            peliculasSet.Add(new TC5_Peliculas("Bad Boys", 1995));
            peliculasSet.Add(new TC5_Peliculas("Bad Boys", 1983));
            peliculasSet.Add(new TC5_Peliculas("Aladdin", 2019));
            peliculasSet.Add(new TC5_Peliculas("Aladdin", 1992));
            // Son objetos distintos, incluso si tienen los mismos datos
            peliculasSet.Add(new TC5_Peliculas("Aladdin", 1992));
            Console.WriteLine("Cant. de películas en peliculasSet: " + peliculasSet.Count);

            // Map --> Java
            // Dictionary -> C#, python
            // Object -> Javascript

            Dictionary<string, string> nombresDePeliculaFavoritas = new Dictionary<string, string>();
            nombresDePeliculaFavoritas.Add("Pablo", "Titanic");
            nombresDePeliculaFavoritas.Add("Esteban", "The Fast and the Furious: Tokyo Drift");
            nombresDePeliculaFavoritas.Add("Octavio", "Barbie in the 12 Dancing Princesses");

            string nombrePeliculaFavoritaPablo = nombresDePeliculaFavoritas.GetValueOrDefault("Pablo");
            Console.WriteLine("nombrePeliculaFavoritaPablo: " + nombrePeliculaFavoritaPablo);

            string nombrePeliculaFavoritaRamiro = nombresDePeliculaFavoritas.GetValueOrDefault("Ramiro");
            Console.WriteLine("nombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro); //null
            nombrePeliculaFavoritaRamiro = nombresDePeliculaFavoritas.GetValueOrDefault("Ramiro", "(Ninguna)");
            Console.WriteLine("nombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro); //(Ninguna)

            nombresDePeliculaFavoritas.Add("Ramiro", "Avatar");
            nombrePeliculaFavoritaRamiro = nombresDePeliculaFavoritas.GetValueOrDefault("Ramiro", "(Ninguna)");
            Console.WriteLine("nombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro); //Avatar

            // Uso real de obtener valores de un Dictionary
            if (nombresDePeliculaFavoritas.TryGetValue("María", out string nombrePeliculaFavoritaMaria))
            {
                Console.WriteLine("nombrePeliculaFavoritaMaria:" + nombrePeliculaFavoritaMaria);
            }
            else
            {
                Console.WriteLine("María no tiene película favorita.");
            }

            // Lista
            Console.WriteLine("---------");
            Console.WriteLine("Lista");
            for (int i = 0; i < nombresDePelicula.Count; i++)
            {
                Console.WriteLine(nombresDePelicula[i]);

            }

            // HashSet
            Console.WriteLine("---------");
            Console.WriteLine("HashSet");
            // foreach: elemento in conjunto
            foreach (string nombrePelicula in nombresDePeliculaSet)
            {
                Console.WriteLine(nombrePelicula);
            }

            // Dictionary
            Console.WriteLine("---------");
            Console.WriteLine("Dictionary");
            foreach (var key in nombresDePeliculaFavoritas.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (var value in nombresDePeliculaFavoritas.Values)
            {
                Console.WriteLine(value);
            }
            foreach (var key in nombresDePeliculaFavoritas.Keys)
            {
                Console.WriteLine(key + ":" + nombresDePeliculaFavoritas.GetValueOrDefault(key));
            }
        }
    }
}
