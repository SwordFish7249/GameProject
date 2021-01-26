using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : GameProp, IGameService
    {

        GameProp[] GameProps;

        public GameManager()
        {
            GameProps = new GameProp[0];
        }
        public void Add(GameProp gameProp)
        {
            GameProp[] tempArray = GameProps;
            GameProps = new GameProp[GameProps.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                GameProps[i] = tempArray[i];
                Console.WriteLine("This game is added" + GameProps[i]);
            }
            GameProps[GameProps.Length - 1] = gameProp;
        }

        public void Delete(GameProp gameProp)
        {
            GameProp[] gameProps = GameProps;
            GameProps = new GameProp[GameProps.Length - 1];
            for(int i = 0; i<GameProps.Length; i++)
            {
                GameProps[i] = GameProps[GameProps.Length - 1];
                Console.WriteLine("This game is deleted" + GameProps[i]);
            }
        }

        public void Sales(GameProp[] gameProps)
        {
            foreach (var gameProp in gameProps)
            {
                Console.WriteLine(gameProp.Name + "The game name is :  \n" + gameProp.Platform + "The game platform is :  \n" + gameProp.Type + "The game type is :  \n" 
                    + gameProp.Price + "The game price is : $" );
            }
        }

        public void Save(GameProp gameProp)
        {
            GameProp[] tempArray = GameProps;
            GameProps = new GameProp[GameProps.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                GameProps[i] = tempArray[i];
                Console.WriteLine("This game is saved" + GameProps[i]);
            }
            GameProps[GameProps.Length - 1] = gameProp;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
