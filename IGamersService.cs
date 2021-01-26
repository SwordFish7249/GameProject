using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IGamersService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
        void Save(Gamer gamer);
    }
}
