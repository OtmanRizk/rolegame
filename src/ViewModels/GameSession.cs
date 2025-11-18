using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.PlayerModel;

namespace ViewModels.GameSession
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        { 
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Gandalf";
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.CharacterClass = "Wizard";
            CurrentPlayer.HitPoints = 100;
            CurrentPlayer.ExperiencePoint = 5000;
            CurrentPlayer.Level = 20;
        }
    }
}
