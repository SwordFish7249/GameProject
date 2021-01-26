using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GameManager : IGameService
    {

        Game[] Games;

        public GameManager()
        {
            Games = new Game[0];
        }
        public void Add(Game game)
        {
            Game[] tempArray = Games;
            Games = new Game[Games.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                Games[i] = tempArray[i];
                Console.WriteLine("This game is added" + Games[i]);
            }
            Games[Games.Length - 1] = game;
        }

        public void Delete(Game game)
        {
            Game[] games = Games;
            Games = new Game[Games.Length - 1];
            for(int i = 0; i<Games.Length; i++)
            {
                Games[i] = Games[Games.Length - 1];
                Console.WriteLine("This game is deleted" + Games[i]);
            }
        }

        public void Sales(Game[] games)
        {
            foreach (var game in games)
            {
                Console.WriteLine(game.Name + "The game name is :  \n" + game.Platform + "The game platform is :  \n" + game.Type + "The game type is :  \n" 
                    + game.Price + "The game price is : $" );
            }
        }

        public void Save(Game game)
        {
            Game[] tempArray = Games;
            Games = new Game[Games.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                Games[i] = tempArray[i];
                Console.WriteLine("This game is saved" + Games[i]);
            }
            Games[Games.Length - 1] = game;
        }

        public void Update(Game game)
        {
            int i;
            for (i = 0; i < game.GameId; i++)
            {
                Console.WriteLine("The gamer is updated : ");
            }
        }
    }
}
