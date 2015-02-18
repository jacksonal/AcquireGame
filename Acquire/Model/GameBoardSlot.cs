using Acquire.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire.Model
{
    public class GameBoardSlot : IGameBoardSlot
    {
        private Util.enHorizontalSlots XCoord;
        private Util.enVerticalSlots YCoord;

        public GameBoardSlot(Util.enHorizontalSlots XCoord, Util.enVerticalSlots YCoord)
        {
            // TODO: Complete member initialization
            this.XCoord = XCoord;
            this.YCoord = YCoord;

            SetName();
        }

        
        public string TileName
        {
            get;
            private set;
        }

        public bool IsFull
        {
            get;
            set;
        }

        private void SetName()
        {
            switch(XCoord)
            {
                case Util.enHorizontalSlots.One:
                    this.TileName = "1";
                    break;
                case Util.enHorizontalSlots.Two:
                    this.TileName = "2";
                    break;
                case Util.enHorizontalSlots.Three:
                    this.TileName = "3";
                    break;
                case Util.enHorizontalSlots.Four:
                    this.TileName = "4";
                    break;
                case Util.enHorizontalSlots.Five:
                    this.TileName = "5";
                    break;
                case Util.enHorizontalSlots.Six:
                    this.TileName = "6";
                    break;
                case Util.enHorizontalSlots.Seven:
                    this.TileName = "7";
                    break;
                case Util.enHorizontalSlots.Eight:
                    this.TileName = "8";
                    break;
                case Util.enHorizontalSlots.Nine:
                    this.TileName = "9";
                    break;
                case Util.enHorizontalSlots.Ten:
                    this.TileName = "10";
                    break;
                case Util.enHorizontalSlots.Eleven:
                    this.TileName = "11";
                    break;
                case Util.enHorizontalSlots.Twelve:
                    this.TileName = "12";
                    break;
            }

            TileName += YCoord.ToString();
        }
    }
}
