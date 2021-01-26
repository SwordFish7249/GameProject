using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamersManager : IGamersService
    {
         IGamerCheckService _gamerCheckService;

        public GamersManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        Gamer[]  Gamers;

            public GamersManager()
        {
            Gamers = new Gamer[0];
        }
        public void Add(Gamer gamer)
        {
            Gamer[] tempArray = Gamers;
            Gamers = new Gamer[Gamers.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                Gamers[i] = tempArray[i];
                Console.WriteLine("This game is added" + Gamers[i]);
            }
            Gamers[Gamers.Length - 1] = gamer;
        }

        public void Delete(Gamer gamer)
        {
            Gamer[] gamers = Gamers;
            Gamers = new Gamer[Gamers.Length - 1];
            for (int i = 0; i < Gamers.Length; i++)
            {
                Gamers[i] = Gamers[Gamers.Length - 1];
                Console.WriteLine("This game is deleted" + Gamers[i]);
            }
        }

        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Gamer is saved : " + gamer.FirstName);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        public void Update(Gamer gamer)
        {
            int i;
            for(i = 0; i<gamer.Id; i++)
            {
                Console.WriteLine("The gamer is updated : " );
            }
        }
    }
}
