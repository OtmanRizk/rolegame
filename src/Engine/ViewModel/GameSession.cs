using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;

namespace Engine.ViewModel
{
    class GameSession
    {
        Player CurrentPlayer { get; set; }

        public GameSession()
        { 
            CurrentPlayer = new Player();
        }



    }
}
