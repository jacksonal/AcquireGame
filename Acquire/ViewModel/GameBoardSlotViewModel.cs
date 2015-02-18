using Acquire.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire.ViewModel
{
	public class GameBoardSlotViewModel : ViewModelBase
	{
		public bool IsFull
		{
			get
			{
				return Slot.IsFull;
			}
			set
			{
				Slot.IsFull = value;
				OnPropertyChanged("IsFull");
			}
		}

		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		public string Name
		{
			get 
			{ 
				return Slot.TileName; 
			}
		}
		public GameBoardSlotViewModel(IGameBoardSlot Slot)
		{
			this.Slot = Slot;
			//OnPropertyChanged("Name");
		}

		private IGameBoardSlot Slot { get; set; }
	}
}
