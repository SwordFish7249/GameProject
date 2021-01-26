using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
