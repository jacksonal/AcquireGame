using Acquire.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire.ViewModel
{
	public class GameBoardColumnViewModel : ViewModelBase
	{
		public IList<GameBoardSlotViewModel> Slots { get;private set; }
		
		public GameBoardColumnViewModel()
		{
			Slots = new List<GameBoardSlotViewModel>();
		}
	}
}
