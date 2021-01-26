using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        void Sales(Game[] game);
        void Save(Game game);
    }
}
