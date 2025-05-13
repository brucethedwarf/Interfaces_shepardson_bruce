using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_shepardson_bruce
{
    internal class Game : IGenre
    {
        public string Esrb { get; set; }

        public string Genre { get; set; }
        public Game(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
             
        }
        
        
        
        public string Title { get; set; }
        public string Describe() 
        {
            return $" {Title} is a(n) {Genre} game, rated {Esrb}!";
        }

        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting! game ON!");
        }
    }       



}
