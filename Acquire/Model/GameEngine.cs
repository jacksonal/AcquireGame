using Acquire.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire.Model
{
    class GameEngine : IGameEngine
    {
        public IGameBoard Board
        {
            get;
            private set;
        }

        public GameEngine()
        {
            Board = new GameBoard();
        }

        public IHotel GetHotel(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
