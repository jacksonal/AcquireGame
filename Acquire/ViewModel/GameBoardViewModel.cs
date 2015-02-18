using Acquire.Model;
using Acquire.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire.ViewModel
{
	public class GameBoardViewModel : ViewModelBase
	{
		public IList<GameBoardColumnViewModel> Columns{get; private set;}

		public GameBoardViewModel(IGameEngine Engine)
		{
			this.Engine = Engine;
			Columns = new List<GameBoardColumnViewModel>();

			BuildBoardVM();
		}
		
		private IGameEngine Engine { get; set; }
		
		private void BuildBoardVM()
		{
			foreach (Enum x in Enum.GetValues(typeof(Util.enHorizontalSlots)))
			{
				GameBoardColumnViewModel col = new GameBoardColumnViewModel();
				Columns.Add(col);
				foreach (Enum y in Enum.GetValues(typeof(Util.enVerticalSlots)))
				{
					col.Slots.Add(new GameBoardSlotViewModel(new GameBoardSlot((Util.enHorizontalSlots)x, (Util.enVerticalSlots)y)));
				}
			}
		}
		
	}
}
