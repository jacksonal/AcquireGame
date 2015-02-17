using Acquire.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire.Model
{
	class GameBoard : IGameBoard
	{
		public GameBoard()
		{
			m_Board = new Dictionary<Util.enHorizontalSlots,Dictionary<Util.enVerticalSlots,IGameBoardSlot>>();
			BuildGameBoard();
			Console.WriteLine(this.ToString());
		}

		public override string ToString()
		{
			string ret = "";
			foreach(Dictionary<Util.enVerticalSlots,IGameBoardSlot> column in m_Board.Values)
			{
				foreach(IGameBoardSlot slot in column.Values)
				{
					ret += string.Format("{0,-3} ", slot.TileName);
				}
				ret += Environment.NewLine;
			}
			return ret;
		}
		public IGameBoardSlot GetSlot(Util.enHorizontalSlots XCoord, Util.enVerticalSlots YCoord)
		{
			IGameBoardSlot ret = null;
			if(m_Board.ContainsKey(XCoord))
			{
				if(m_Board[XCoord].ContainsKey(YCoord))
				{
					ret = m_Board[XCoord][YCoord];
				}
			}
			return ret;
		}

		protected  Dictionary<Util.enHorizontalSlots,Dictionary<Util.enVerticalSlots,IGameBoardSlot>> m_Board;
		
		private void BuildGameBoard()
		{
			foreach(Enum x in Enum.GetValues(typeof(Util.enHorizontalSlots)))
			{
				foreach (Enum y in Enum.GetValues(typeof(Util.enVerticalSlots)))
				{
					AddSlot((Util.enHorizontalSlots)x, (Util.enVerticalSlots)y);
				}
			}
		}

		private void AddSlot(Util.enHorizontalSlots XCoord, Util.enVerticalSlots YCoord)
		{   
			if(!m_Board.ContainsKey(XCoord))
			{
				m_Board[XCoord] = new Dictionary<Util.enVerticalSlots,IGameBoardSlot>();
			}

			Dictionary<Util.enVerticalSlots,IGameBoardSlot> column = m_Board[XCoord];

			if(!column.ContainsKey(YCoord))
			{
				column[YCoord] = new GameBoardSlot(XCoord,YCoord);
			}
		}
	}
}
