namespace Interfaces_shepardson_bruce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game mygame = new Game("E", "FPS", "Zomecube");
            Console.WriteLine(mygame.Describe());
            mygame.PlayGame();

            Movie myMovie = new Movie("PG", "adventer/comedy", "Sonic the Hedgehog 2");
             Console.WriteLine(myMovie.Describe());
              myMovie.PlayMovie();
        } 


    }
}