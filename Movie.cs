using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_shepardson_bruce
{
    // Define a class named Movie that implements the IGenre interface
    internal class Movie : IGenre
    {
        // Public property to store ESRB rating (e.g., PG, R, etc.)
        public string Esrb { get; set; }

        // Public property to store the genre of the movie (e.g., Action, Comedy)
        public string Genre { get; set; }

        // Public property to store the title of the movie
        public string Title { get; set; }

        // Constructor to initialize a Movie object with ESRB, genre, and title
        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        // Method to simulate playing the movie
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting SSsssshhhh!");
        }

        // Method that describes the movie with its title, genre, and rating
        public string Describe()
        {
            return $"{Title} is a {Genre} movie, rated {Esrb}!";
        }

        // Method required by the IGenre interface, but not implemented for Movie
        public void PlayGame()
        {
            // Throws an exception because movies don't support playing games
            throw new NotImplementedException();
        }
    }
}
