using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acquire.Model;
using Acquire.Model.Interfaces;

namespace Acquire.Test.Implementation
{
	class TestGameBoard : GameBoard
	{
		/// <summary>
		/// Gets the board.
		/// </summary>
		/// <returns></returns>
		public Dictionary<Util.enHorizontalSlots,Dictionary<Util.enVerticalSlots,IGameBoardSlot>> GetBoard()
		{
			return m_Board;
		}
	}
}
