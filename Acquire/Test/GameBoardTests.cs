using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Acquire.Model;
using Acquire.Test.Implementation;
using Acquire.Model.Interfaces;

namespace Acquire.Test
{
	[TestFixture]
	class GameBoardTests
	{
		private TestGameBoard m_SystemUnderTest;

		[SetUp]
		public void Setup()
		{
			m_SystemUnderTest = new TestGameBoard();
		}

		[TearDown]
		public void TearDown()
		{

		}

		[Test]
		public void GameBoard_Constructed_AllSlotsExist()
		{
			Dictionary<Util.enHorizontalSlots, Dictionary<Util.enVerticalSlots, IGameBoardSlot>> board = m_SystemUnderTest.GetBoard();
			foreach (Enum x in Enum.GetValues(typeof(Util.enHorizontalSlots)))
			{
				foreach (Enum y in Enum.GetValues(typeof(Util.enVerticalSlots)))
				{
					Assert.IsNotNull(m_SystemUnderTest.GetSlot((Util.enHorizontalSlots)x, (Util.enVerticalSlots)y));
				}
			}
		}
	}
}
