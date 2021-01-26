using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerCheckManager : IGamerCheckService  
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
